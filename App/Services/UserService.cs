using Microsoft.AspNetCore.Http.HttpResults;
using MoodTunesApp.App.DTOs;
using MoodTunesApp.App.Models;
using MoodTunesApp.App.Repositories;
using MoodTunesApp.App.Services.Interfaces;

namespace MoodTunesApp.App.Services
{
    public class UserService : IGerericService<UserDTO>
    {

        private readonly UserRepository _userRepository;
        private readonly MoodMaterRepository _moodMaterRepository;
        private readonly LibraryRepository _libraryRepository; 

        public UserService(UserRepository userRepository, MoodMaterRepository moodMaterRepository, LibraryRepository libraryRepository)
        {
            _userRepository = userRepository;
            _moodMaterRepository = moodMaterRepository;
            _libraryRepository = libraryRepository;
        }

        public Task Add(UserDTO entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto> CreateUser(UserDTO UserDto)
        {
            try
            {
                if (UserDto.Password != UserDto.RePassword)
                {
                    throw new InvalidOperationException("Senha não coincidem!");
                }

                var users = await _userRepository.GetAll();
                if (users.Any(u => u.Email == UserDto.Email))
                {
                    throw new InvalidOperationException("Email fornecido invalido!");
                }

                MoodMater moodMater = new() {};

                Library library = new()
                {
                    Name = $"{UserDto.UserName} Library"
                };

                await _moodMaterRepository.Add(moodMater);
                await _libraryRepository.Add(library);

                User user = new()
                {
                    UserName = UserDto.UserName,
                    Email = UserDto.Email,
                    Password = UserDto.Password,
                    LibraryId = library.Id,
                    MoodMaterId = moodMater.Id
                };

                await _userRepository.Add(user);

                return new ResponseDto
                {
                    Success = true,
                    Message = "Usuário criado com sucesso!",
                    Data = user
                };
            }
            catch (Exception ex)
            {
                return new ResponseDto
                {
                    Success = false,
                    Message = $"Erro ao criar usuário: {ex.Message}",
                    Data = null
                };
            }
        }

        public UserDTO Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserDTO GetById(string id)
        {
            throw new NotImplementedException();
        }

        public UserDTO Update(UserDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}