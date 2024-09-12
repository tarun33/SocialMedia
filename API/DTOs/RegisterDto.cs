using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Win32.SafeHandles;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    public  string Username { get; set; } = string.Empty;

    [Required]
    [StringLength(8,MinimumLength = 4)]
    public  string Password { get; set; } =string.Empty;
}
