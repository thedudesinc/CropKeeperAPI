using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CropKeeperApi.Domain.Abstractions.Services;
using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.App.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Net;

namespace CropKeeperApi.App.Controllers;

[ApiController]
[Route("api/authentication")]

public class AuthenticationController
{
    private readonly IConfiguration _configuration;
    private readonly IAuthenticationService _authenticationService;
    private readonly IUserService _userService;

    public AuthenticationController(IConfiguration configuration, IAuthenticationService authenticationService, IUserService userService)
    {
        _configuration = configuration;
        _authenticationService = authenticationService;
        _userService = userService;
    }

    [HttpPost]
    [Route("login")]
    [AllowAnonymous]
    public async Task<ActionResult<LoginResponse>> Login([FromBody] LoginInput user, CancellationToken ct)
    {
        var userResponse = await _authenticationService.Authenticate(user, ct);

        if (userResponse == null) throw new HttpRequestException("unauthorized", null, HttpStatusCode.Unauthorized);

        var issuer = _configuration.GetValue<string>("Jwt:Issuer");
        var audience = _configuration.GetValue<string>("Jwt:Audience");
        var key = Encoding.ASCII.GetBytes(_configuration.GetValue<string>("Jwt:Key"));
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim("Id", Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
             }),
            Expires = DateTime.UtcNow.AddMinutes(30),
            Issuer = issuer,
            Audience = audience,
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
        };
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        var jwtToken = tokenHandler.WriteToken(token);
        var stringToken = tokenHandler.WriteToken(token);
        var loginResponse = new LoginResponse()
        {
            DisplayName = userResponse.DisplayName,
            Email = userResponse.Email,
            AllowEmailNotifications = userResponse.AllowEmailNotifications,
            AllowSiteNotifications = userResponse.AllowSiteNotifications,
            StringToken = stringToken
        };
        return loginResponse;
    }
}
