using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Jwt_Core_Kampi_Api.Dal
{
    public class BuildToken
    {
        public string CreateToken()
        {
            var bytes= Encoding.UTF8.GetBytes("aspnetcorekampi");
            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(1),signingCredentials:credentials);
            JwtSecurityTokenHandler hanler = new JwtSecurityTokenHandler();
            return hanler.WriteToken(token);
        }
    }
}
