using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountRevisitedAgain
{
	public class BankAccount
	{
		private string Owner;
		public double Balance { get; private set; }
		private int PIN;
		public BankAccount(string name, int pin)
		{
			Owner = name;
			PIN = pin;
		}
		public void SetPin(int pin)
		{   // employ other method for verification
			PIN = pin;
		}
		public void Deposit(double amount)
		{
			Balance += amount;
		}
		public void Withdraw(double amount, int pin)
		{
			if (PIN == pin)
				Balance -= amount;
		}
		public void Transfer(double amount, BankAccount target, int pin)
		{
			if (PIN == pin)
			{
				Balance -= amount;
				target.Balance += amount;
				Console.WriteLine("Transfer Successful...");
			}
			else
			{
				Console.WriteLine("Incorrect Pin!\nTransfer Canceled.");
			}
		}
		public void ShowAccountInformation()
		{
			Console.Write("Account Name: " + Owner + ", ");
			Console.WriteLine("Balance: ${0}.", Balance);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var John = new BankAccount("John Lion", 4357);
			John.Deposit(500);
			var Bob = new BankAccount("Bob Marley", 7356);
			John.ShowAccountInformation();
			Bob.ShowAccountInformation();
			John.Transfer(60, Bob, 4357);
			John.ShowAccountInformation();
			Bob.ShowAccountInformation();
			John.Transfer(60, Bob, 1234);
			John.ShowAccountInformation();
			Bob.ShowAccountInformation();
			Console.ReadLine();
		}
	}
}
