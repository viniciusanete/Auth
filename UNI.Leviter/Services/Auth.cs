using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UNI.Leviter.Models.Context;

namespace UNI.Leviter.Services
{
    public class Auth
    {
        private LeviterDBContext db = new LeviterDBContext();

        public static bool Login(string login, string senha)
        {
            using (LeviterDBContext entities = new LeviterDBContext())
            {
                return entities.Usuario.Any(user =>
                               user.Login.Equals(login, StringComparison.OrdinalIgnoreCase)
                               && user.Senha == senha);
            }
        }
    }
}