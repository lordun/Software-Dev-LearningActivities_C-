using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
	public class BankAccount
	{
		private double balance;
		public void Deposit(double amount)
		{
			balance += amount;
		}

		public void Withdraw(double amount)
		{
			balance -= amount;
		}

		public double GetBalance()
		{
			return balance;
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
			Console.WriteLine("Balance of John: $" + John.GetBalance());
			Console.WriteLine("Balance of Bob: $" + Bob.GetBalance());
			John.Transfer(60, Bob);
			Console.WriteLine("After John Transfers $60 to Bob: ");
			Console.WriteLine("Balance of John: $" + John.GetBalance());
			Console.WriteLine("Balance of Bob: $" + Bob.GetBalance());
			Console.Read();
		}
	}
}
