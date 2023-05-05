using System;
using System.Collections.Generic;
using System.Text;

namespace QLyQuanAn.Storage
{
    public class Account
    {
        private static DTO.Account acc = new DTO.Account();

        public static void SetAccount(DTO.Account acc1)
        {
            acc = acc1;
        }
        public static DTO.Account GetAccount()
        {
            return acc;
        }

        public static void DeleteAccount()
        {
            acc = new DTO.Account();
        }
    }
}
