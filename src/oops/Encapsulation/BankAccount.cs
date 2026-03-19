using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
using System.IO.Pipes;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class BankAccount
{
      private decimal balance ; 

      public BankAccount(decimal balance)
      {
            this.balance = 0 ; 
            Deposit(balance) ; 
      }

      public decimal GetBalance ()
      {
            return this.balance ; 
      }
      public void Deposit(decimal amount) {
            
            if (amount <= 0)
            {
                  throw new ArgumentException("Amount must be positive") ; 
            }

            this.balance += amount ; 
      }

      public void Withdraw (decimal amount)
      {
            if (amount <= 0 )
            {
                  throw new ArgumentException("Amount must be positive") ; 

            }

            if (amount > balance)
            {
                  throw new InvalidOperationException("Insufficient funds") ; 
            }

            this.balance -= amount ; 
      }


}