// using System.IdentityModel.Tokens.Jwt;
// using System.Security.Claims;
// using System.Text;
// using Microsoft.IdentityModel.Tokens;
// using MoodTunesApp.App.Config;
// using MoodTunesApp.App.Models;

// namespace MoodTunesApp.App.Services
// {
//     public class TokenService
//     {
//         public static string GenerateToken(User user)
//         {
//             var tokenHendler = new JwtSecurityTokenHandler();
//             var key = Encoding.ASCII.GetBytes(Settings.Secret);
//             var tokenDescriptor = new SecurityTokenDescriptor
//             {
//                 Subject = new ClaimsIdentity(new Claim[])
//                 {
//                     new Claim(ClaimTypes.Name, user)
//                 }
//             }
//         }
//     }   
// }