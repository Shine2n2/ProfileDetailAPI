﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfileDetailApi.Interfaces;

namespace ProfileDetailApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet("/me")]
        public async Task<IActionResult> GetProfileAsync()
        {
            var result = await _profileService.GetProfileAsync();
            return Ok(result);
        }
    }
}
