﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
	public static class ClaimExtensions
	{
		public static void AddEmail(this ICollection<Claim> claims, string email)
		{
			claims.Add((new Claim(JwtRegisteredClaimNames.Email, email)));
		}
		public static void AddName(this ICollection<Claim> claims, string name)
		{
			claims.Add((new Claim(ClaimTypes.Name, name)));
		}
		public static void AddSurName(this ICollection<Claim> claims, string surName)
		{
			claims.Add((new Claim(ClaimTypes.Name, surName)));
		}

		public static void AddNameId(this ICollection<Claim> claims, string nameId)
		{
			claims.Add((new Claim(ClaimTypes.NameIdentifier, nameId)));
		}
		public static void AddRoles(this ICollection<Claim> claims, string[] roles)
		{
			roles.ToList().ForEach(role => claims.Add(new Claim(ClaimTypes.Role, role)));

		}

		public static void AddUserName(this ICollection<Claim> claims, string userName)
		{
			claims.Add((new Claim(JwtRegisteredClaimNames.Name, userName)));
		}

	}
}
