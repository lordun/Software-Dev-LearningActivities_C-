using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountRevisited
{
		public class BankAccount
		{
			public double Balance { get; private set; } // defining properties, set is private
			public void Deposit(double amount)
			{
				// you may have other functionality to ensure the authenticity of the transection
				Balance += amount;
			}
			public void Withdraw(double amount)
			{
				Balance -= amount;
			}
			public void Transfer(double amount, BankAccount target)
			{
				Withdraw(amount);
				target.Deposit(amount);
			}
		}
		class Program
		{
			static void Main(string[] args)
			{
				var John = new BankAccount();
				John.Deposit(100);
				var Bob = new BankAccount();
				Console.WriteLine("Before Transfer: ");
				Console.WriteLine("Balance of John: $" + John.Balance);
				Console.WriteLine("Balance of Bob: $" + Bob.Balance);
				John.Transfer(60, Bob);
				Console.WriteLine("After John Transfers $60 to Bob: ");
				Console.WriteLine("Balance of John: $" + John.Balance);
				Console.WriteLine("Balance of Bob: $" + Bob.Balance);
				Console.Read();
			}
		}
}
