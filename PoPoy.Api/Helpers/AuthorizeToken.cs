﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using PoPoy.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoPoy.Api.Helpers
{
    internal class AuthorizeToken : AuthorizeAttribute
    {
        public const string ADMIN_STAFF = RoleName.Admin ;
        public const string PAGEADMIN = RoleName.Admin  + "," + RoleName.Shipper;
        public const string ADMIN_SHIPPER = RoleName.Admin + "," + RoleName.Shipper;
        public const string STAFF_SHIPPER = RoleName.Shipper;
        public const string CUSTOMER_SHIPPER = RoleName.Customer + "," + RoleName.Shipper;
        public const string CUSTOMER_STAFF = RoleName.Customer ;
        public const string ALL = RoleName.Customer + "," + RoleName.Shipper + "," + RoleName.Admin;




        public AuthorizeToken(string roles = ALL )
        {
            base.Roles = roles;
            base.AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme;
        }
    }
}
