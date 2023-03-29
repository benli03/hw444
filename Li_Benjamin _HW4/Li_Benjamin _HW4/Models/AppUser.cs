using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace Li_Benjamin_HW4.Models
{
	public class AppUser : IdentityUser
	{
		[Display(Name = "First Name")]
		public String FirstName { get; set; }

		[Display(Name = "Last Name")]
		public String LastName { get; set; }
	}
}

