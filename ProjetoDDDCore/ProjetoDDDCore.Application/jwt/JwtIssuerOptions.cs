﻿using System;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace ProjetoDDDCore.Application.jwt
{
    public class JwtIssuerOptions
    {
  
        public string Issuer { get; set; }

        public string Subject { get; set; }

        public string Audience { get; set; }

        public DateTime Expiration => IssuedAt.Add(ValidFor);

        public DateTime NotBefore => DateTime.UtcNow;

        public DateTime IssuedAt => DateTime.UtcNow;

        public TimeSpan ValidFor { get; set; } = TimeSpan.FromMinutes(120);

        /// "jti" (JWT ID) Claim (default ID is a GUID)
        public Func<Task<string>> JtiGenerator =>
          () => Task.FromResult(Guid.NewGuid().ToString());

        public SigningCredentials SigningCredentials { get; set; }
    }
}
