using Hotel_Management_Service.Shared.DTOs;
using Hotel_Management_System.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_Service.Contract
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(CustomerDetailsDto customer);
        Task<bool> ValidateUser(UserAuthenticationDto userForAuth);
        Task<string> CreateToken();
    }
}
