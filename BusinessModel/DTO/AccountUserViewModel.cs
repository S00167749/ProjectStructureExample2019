using BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessModel.DTO
{
    public class AccountUserViewModel
    {
        //the type of data you want sent back
        public string AccountManagerID { get; set; }
        public string AccountManagerName { get; set; }
        public List<Account> accounts { get; set; }
    }
}