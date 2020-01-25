using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms{
   public class BankCustmor{
          string name;
          string bankingActivity;
          long accountNumber;
          float amount;
        public BankCustmor(string name,string activity,long accNumber,float amount)
        {
            this.name = name;
            this.bankingActivity = activity;
            this.accountNumber = accNumber;
            this.amount = amount;
        }
       
    }
}
