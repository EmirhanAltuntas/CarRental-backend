﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;


namespace Core.Utilities.Security.Enrcyption
{
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
