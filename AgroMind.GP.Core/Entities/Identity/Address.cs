﻿namespace AgroMind.GP.Core.Entities.Identity
{
	public class Address:BaseEntity<string>
	{
		
		public string? Fname { get; set; } // who will receive order

		public string? Lname { get; set; }

		public string? city { get; set; }

		public string? street { get; set; }

		public string? country { get; set; }

		public string? State { get; set; }
		public string? ZipCode { get; set; }
		
		//public string AppUserId { get; set; } //take PK of Optional put it in Manadatory //string because type of id of AppUser is guid->string
		//should to do that to clear to EFcore Which Table is Mandatory(address) and which is Optional(user)
		public AppUser? AppUser { get; set; }                                  

		

	}
}
