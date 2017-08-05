using BackEnd_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace BackEnd_Api
{
    public class MyPrincipal : IPrincipal
    {
        public IIdentity Identity { get; private set; }
        public static string UserDefault = "Administrator";
        public User UserEntity;
        public MyPrincipal()
        {
            this.Identity = new GenericIdentity(UserDefault);
        }
        public MyPrincipal(User UserEntity)
        {
            this.Identity = new GenericIdentity(UserEntity.name);
            this.UserEntity = UserEntity;
        }

        public bool IsInRole(string role)
        {
            return true;
        }
    }
}