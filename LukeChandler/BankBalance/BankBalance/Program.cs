/********
** Name: Chandler, Luke
** Class: CS132
** Project: PE09E01 
** Date: 2020-12-06
** Description: Program for displaying Checking, Savings, and Joint Savings accounts
*********/

using System;

namespace BankBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal OPENING_BALANCE = 55m;
            const decimal MONTHLY_INTEREST = 0.0033m;

			//Create and use Savings object.
			Savings savings = new Savings(OPENING_BALANCE);
			savings.AddMonthlyInterest(MONTHLY_INTEREST);
			savings.ShowBalance();

			//Create and use Checking object.
			Checking checking = new Checking(OPENING_BALANCE);
			checking.DeductServiceCharge();
			checking.ShowBalance();

			//Create and use JointSavings object.
			JointSavings jointSavings = new JointSavings("George", "Jane", OPENING_BALANCE);
			jointSavings.DisplayOwners();
			jointSavings.AddMonthlyInterest(MONTHLY_INTEREST);
			jointSavings.ShowBalance();
			Console.ReadLine();

        }
    }

	//Base class Account
    class Account
    {
        protected decimal BankBalance { set; get; }

        protected Account()
        {
            Console.WriteLine();
            Console.WriteLine("Inside the Account constructor.");
        }

        public void ShowBalance()
        {
            Console.WriteLine("The balance is " + BankBalance.ToString("C"));
        }
    }

    //Derived class - Savings
    class Savings : Account
    {
		public Savings(decimal balance)
		{
			Console.WriteLine("Inside the Savings constructor.");
			BankBalance = balance;
		}

		//Custom Child Method
		public void AddMonthlyInterest(decimal interest)
		{
			BankBalance *= (1.0m + interest);
		}
	}

	//Derived class - Checking
	class Checking : Account
	{
		public Checking(decimal balance)
		{
			Console.WriteLine("Inside the Checking constructor.");
			BankBalance = balance;
		}

		//Custom Child Method
		public void DeductServiceCharge()
		{
			const decimal CHECKING_FEE = 1.50M;
			BankBalance -= CHECKING_FEE;
		}
	}

	//Derived class of Savings - JointSavings
	class JointSavings : Savings
	{
		protected string firstNameA;
		protected string firstNameB;

		public JointSavings(string firstNameA, string firstNameB, decimal balance) : base(balance)
		{
			Console.WriteLine("Inside the JointSavings constructor.");
			this.firstNameA = firstNameA;
			this.firstNameB = firstNameB;
		}

		//Custom Child Method
		public void DisplayOwners()
		{
			Console.WriteLine($"The account owners are: {firstNameA} and {firstNameB}");
		}
	}
}
