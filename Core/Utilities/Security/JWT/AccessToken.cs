using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    //Erişim Token
    public class AccessToken
    {
        public string Token { get; set; } // token
        public DateTime Expiration { get; set; } // bitiş zamanı
    }
}
