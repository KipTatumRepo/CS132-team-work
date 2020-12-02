/********
**
**Name: Tatum, Kip
**Class: CS 132
**Project: 09 
**Date: 2020-30-11
**Description:  This program will show various account balances after constructor are called with
** global variables
*********/
using System;

namespace Banking
{
	class Program
	{
		//base class 
		class Account 
		{
			protected decimal BankBalance { get; set; }
			protected Account()
			{
				Console.WriteLine();
				Console.WriteLine("Inside the Account constructor");
			}

			//display the balance of the account
			public void ShowBalance()
			{
				Console.WriteLine("The balance is " + BankBalance.ToString("C"));
			}
		}

		//Savings class derived from account, this class can show a balance with interest applied
		class Savings : Account
		{
			public Savings(decimal balance)
			{
				Console.WriteLine("Inside the default Savings constructor.");
				BankBalance = balance;
			}

			//add monthly interest to the given balance of the savings account
			public void AddMonthlyInterest(decimal interest)
			{
				BankBalance *= (1.0m + interest);
			}
		}

		//Checking class derived from account, this class can show a balance after a checking account fee is deducted
		class Checking : Account
		{
			public Checking(decimal balance)
			{
				Console.WriteLine("Inside the Checking constructor.");
				BankBalance = balance;
			}

			//Take out the monthly service charge from the account balance
			public void DeductServiceCharge()
			{
				const decimal CHECKING_FEE = 1.5M;
				BankBalance -= CHECKING_FEE;
			}
		}

		//A co-owned savings account that can show both owners and balance after interest is applied
		class JointSavings : Savings
		{
			protected string firstNameA;
			protected string firstNameB;

			//Constructor that will take in the given names to assign the account to them
			public JointSavings(string firstNameA, string firstNameB, decimal balance) : base(balance)
			{
				Console.WriteLine("Inside the JointSavings constructor.");
				this.firstNameA = firstNameA;
				this.firstNameB = firstNameB;
			}

			//display owners of the joint account
			public void ShowOwners()
			{
				Console.WriteLine($"The owners of this joint account are {firstNameA} and {firstNameB}");
			}
		}
		static void Main(string[] args)
		{
			const decimal OPENING_BALANCE = 55m;
			const decimal MONTHLY_INTEREST = 0.0033m;

			//add monthly interest to savings account and display balance
			Savings savings = new Savings(OPENING_BALANCE);
			savings.AddMonthlyInterest(MONTHLY_INTEREST);
			savings.ShowBalance();

			//deduct the monthly check fee from the account balance and display balance
			Checking checking = new Checking(OPENING_BALANCE);
			checking.DeductServiceCharge();
			checking.ShowBalance();

			//show the 2 owners of the joint account, plus add interest to the balance and display the balance
			JointSavings jointSavings = new JointSavings("Bob", "Martha", OPENING_BALANCE);
			jointSavings.ShowOwners();
			jointSavings.AddMonthlyInterest(MONTHLY_INTEREST);
			jointSavings.ShowBalance();
			Console.ReadKey();
		}
	}
}
