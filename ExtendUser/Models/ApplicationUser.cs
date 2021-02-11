using System;
using Microsoft.AspNetCore.Identity;

namespace ExtendUser.Models
{
    public class ApplicationUser : IdentityUser
    {
        //First name of user
        public string FirstName {get; set;}

        // Last name of user
        public string LastName {get; set;}

        // LONG VERSION OF WHAT THE ABOVE GET SET IS DOING
        // void setFirstName(string newFirstName)
        // {
        //     this.FirstName = newFirstName;
        // }

        // string getFirstName()
        // {
        //     return this.FirstName;
        // }
    }
}
