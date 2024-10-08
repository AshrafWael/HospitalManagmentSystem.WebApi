﻿using HospitalManagmentSystem.BLL.Dtos.AccountDtos;
using HospitalManagmentSystem.BLL.Manager.Accounts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HospitalManagmentSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AccountsController : ControllerBase
    {
        private readonly IAccountManager _accountManager;

        public AccountsController(IAccountManager accountManager)
        {
            _accountManager = accountManager;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login(AccountLoginDto loginDto)
        {
            var result = await _accountManager.Login(loginDto);
            if (result == null)
            {
                return Unauthorized();   
            }
                return Ok(result);
        }
        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(AccountRegisterDto registerDto)
        {
            var result =  await _accountManager.Register(registerDto);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
