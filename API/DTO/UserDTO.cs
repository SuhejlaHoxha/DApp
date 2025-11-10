using System;

namespace API.DTO;

public class UserDTO
{
    public required string Id { get; set; }   
    public required string DisplayName { get; set; }
    public required string Email { get; set; }
    public string? ImageUrl { get; set; }
    public required string Token { get; set; }

}
