using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.ObjectModel;

namespace Assignment_2
{
    public class Menus
    {

        private List<Customer> customers = new List<Customer>();
        public List<Customer> Customers
        {
            get { return customers; }
        }

        private List<Account> accounts = new List<Account>();
        public List<Account> Accounts
        {
            get { return accounts; }
        }

        public Menus(List<Customer> inputCustomers, List<Account> inputAccounts)
        {
            customers = inputCustomers;
            accounts = inputAccounts;
        }

        public void MainMenu()
        {
            bool done = true;

            while (done)
            {
                Console.WriteLine("Main Menu");

                Console.WriteLine("1. Create New Customer");
                Console.WriteLine("2. Search for Customer");
                Console.WriteLine("3. Open an Account");
                Console.WriteLine("4. Seatch an Account");
                Console.WriteLine("5. Transfer Money");
                Console.WriteLine("6. Deposit");
                Console.WriteLine("7. Withdraw");
                Console.WriteLine("8. Set Monthly Deposit");
                Console.WriteLine("Any Other Key to Exit");
                string strSelection = Console.ReadLine();
                int iSel;
                try
                {
                    iSel = int.Parse(strSelection);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Selection . . Exiting\n");
                    break;
                }

                switch (iSel)
                {
                    case 1:
                        NewCustomer();
                        break;
                    case 2:
                        SearchCustomer();
                        break;
                    case 3:
                        OpenAccount();
                        break;
                    case 4:
                        SearchAccount();
                        break;
                    case 5:
                        Transfer();
                        break;
                    case 6:
                        Deposit();
                        break;
                    case 7:
                        Withdraw();
                        break;
                    case 8:
                        MonthlyDeposit();
                        break;
                }
            }
        }

            
        
    

        public void NewCustomer()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nCreate New Customer Menu");
                Console.WriteLine();
                Console.WriteLine("First Name");
                var FirstName = Console.ReadLine();
                Console.WriteLine("Last Name");
                var LastName = Console.ReadLine();
                Console.WriteLine("Address");
                var Address = Console.ReadLine();
                Console.WriteLine("DOB");
                DateTime DOB;
                DateTime.TryParse(Console.ReadLine(), out DOB);
                Console.WriteLine("Phone Number");
                var PhoneNumber = Console.ReadLine();
                Console.WriteLine("Email");
                var Email = Console.ReadLine();
                Console.Write("\nPress S to Sumbit or Any Other Key to Exit: ");
                char Submit = Console.ReadKey().KeyChar;
                if (Submit == 's' || Submit == 'S')
                {
                    try
                    {
                        //validate DOB & PhoneNumber
                        Validation.ValidateDOB(DOB);
                        Validation.ValidatePhoneNumber(PhoneNumber);
                        customers.Add(new Customer(FirstName, LastName, Address, DOB, PhoneNumber, Email));
                        Console.WriteLine("\nCustomer Created\n");
                        break;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    flag = false;
                }

                else
                {
                    MainMenu();
                }

            }

        }



        public void SearchCustomer()
            {
            bool flag = true;
            while (flag)
            {
                //Is every field entered by user??
                Console.WriteLine("Customer Search Menu");
                Console.WriteLine();
                Console.WriteLine("First Name: ");
                var FirstName = Console.ReadLine();
                Console.WriteLine("Last Name: ");
                var LastName = Console.ReadLine();
                Console.WriteLine("Address: ");
                var Address = Console.ReadLine();
                Console.WriteLine("DOB: ");
                DateTime DOB;
                DateTime.TryParse(Console.ReadLine(), out DOB);
                Console.WriteLine("Phone Number");
                var PhoneNumber = Console.ReadLine();
                Console.WriteLine("Email");
                var Email = Console.ReadLine();
                Console.Write("Press S to Sumbit or Any Other Key to Exit: ");
                char Submit = Console.ReadKey().KeyChar;
                if (Submit == 's' || Submit == 'S')
                {
                    //search customer list for inputs
                    var customerFound = customers.Where(x => x.FirstName == FirstName || x.LastName == LastName || x.Address == Address || x.DOB == DOB || x.PhoneNumber == PhoneNumber || x.Email == Email).ToArray();

                    //print out account details that match search
                    foreach (var item in customerFound)
                    {
                        Console.WriteLine("\n{0}", item);
                    }
                    flag = false;
                }
                else
                {
                    MainMenu();
                }
            }
        }


        public void OpenAccount()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Create New Account Menu");
                Console.WriteLine();
                Console.WriteLine("Enter Owner ID:");
                uint ID = Convert.ToUInt16(Console.ReadLine());
                Console.WriteLine("Enter Account Type {1 or 2}: ");
                string AccType = Console.ReadLine();

                Customer custID = null;
                //search for customer ID in customer list
                foreach (Customer cust in customers)
                    if (cust.AccID == ID)
                    {
                        custID = cust;
                    }

                Console.WriteLine("Enter Intial Balance: ");
                decimal Balance = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Press S to Sumbit or Any Other Key to Exit: ");
                char Submit = Console.ReadKey().KeyChar;
                if (Submit == 's' || Submit == 'S')
                {
                    try
                    {
                        Validation.ValidateAccountID(ID, accounts);
                        Validation.ValidateAccType(AccType);
                        Validation.ValidateAmount(Balance);

                        //check which account type is to be opened
                        if (AccType == "1")
                        {
                            accounts.Add(new Type1Acc(custID, DateTime.Now, Balance));
                        }
                        else
                        {
                            accounts.Add(new Type2Acc(custID, DateTime.Now, Balance));
                        }
                                
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    flag = false;
                }
            }
        }

        public void SearchAccount()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Account Search Menu");
                Console.WriteLine();
                Console.WriteLine("Enter Account ID: ");
                uint ID;
                uint.TryParse(Console.ReadLine(), out ID);
                Console.Write("Press S to Sumbit or Any Other Key to Exit: ");
                char Submit = Console.ReadKey().KeyChar;
                if (Submit == 's' || Submit == 'S')
                {
                    //search for ID in customers list
                    var idFound = customers.Where(x => x.ID == ID).ToArray();
                    foreach (var item in idFound)
                    {
                        Console.WriteLine("\n {0}", item);
                    }
                    flag = false;
                }
                else
                {
                    MainMenu();
                }
            }

        }

        public void Transfer()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Source Account ID");
                uint SourceID;
                uint.TryParse(Console.ReadLine(), out SourceID);
                Console.WriteLine("Enter Desination Account ID");
                uint DestinationID;
                uint.TryParse(Console.ReadLine(), out DestinationID);

                // search for the source account
                Account SourceAccount = null;
                foreach (Account acc in accounts)
                    if (acc.AccID == SourceID)
                    {
                        SourceAccount = acc;
                        break;
                    }

                // search for the destination account
                Account DestinationAccount = null;
                foreach (Account acc in accounts)
                    if (acc.AccID == DestinationID)
                    {
                        DestinationAccount = acc;
                        break;
                    }

                Console.WriteLine("Enter Transfer Amount: ");
                decimal Amount= Convert.ToDecimal(Console.ReadLine());
                Console.Write("Press S to Sumbit or Any Other Key to Exit: ");
                char Submit = Console.ReadKey().KeyChar;
                if (Submit == 's' || Submit == 'S')
                {
                    try
                    {
                        //validate source and to Id's
                        //validate amount
                        Validation.ValidateAccountID(SourceID, accounts);
                        Validation.ValidateAccountID(DestinationID, accounts);
                        Validation.ValidateBalance(Amount);

                        //Call transfer Method
                        SourceAccount.Transfer(DestinationAccount, Amount);
                        Console.WriteLine("\n$\t{0} transfered", Amount);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message); 
                    }
                    flag = false;
                }
                else
                {
                    MainMenu();
                }
            }
        }


        public void Deposit()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Account ID");
                uint ID;
                uint.TryParse(Console.ReadLine(), out ID);

                // search for the source account
                Account ToAccount = null;
                foreach (Account acc in accounts)
                    if (acc.AccID == ID)
                    {
                        ToAccount = acc;
                        break;
                    }

                Console.WriteLine("Enter Transfer Amount: ");
                decimal Amount = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Press S to Sumbit or Any Other Key to Exit: ");
                char Submit = Console.ReadKey().KeyChar;
                if (Submit == 's' || Submit == 'S')
                {
                    try
                    {
                        //validate ID and amount
                        Validation.ValidateAccountID(ID, accounts);
                        Validation.ValidateAmount(Amount);
                        // Call Deposit Method
                        ((Type1Acc)ToAccount).Deposit(Amount);
                        Console.WriteLine("\n${0} deposited", Amount);

                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    flag = false;
                }
                else
                {
                    MainMenu();
                }
            }
            
        }

         public void Withdraw()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Account ID");
                uint ID;
                uint.TryParse(Console.ReadLine(), out ID);

                Account ToAccount = null;
                //Check if ID exists
                foreach (Account acc in accounts)
                    if (acc.AccID == ID)
                    {
                        ToAccount = acc;
                        break;
                    }

                Console.WriteLine("Enter Withdraw Amount: ");
                decimal Amount = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Press S to Sumbit or Any Other Key to Exit: ");
                char Submit = Console.ReadKey().KeyChar;
                if (Submit == 's' || Submit == 'S')
                {
                    try
                    {
                        //Validate ID and Amount
                        Validation.ValidateAccountID(ID, accounts);
                        Validation.ValidateAmount(Amount);
                        //Call Withdraw method in Account
                        ((Type1Acc)ToAccount).Withdraw(Amount);
                        Console.WriteLine("\n${0} withdrawn", Amount);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    flag = false;

                }
                else
                {
                    MainMenu();    
                }
            }

        }

       public void MonthlyDeposit()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Account ID");
                uint ID;
                uint.TryParse(Console.ReadLine(), out ID);

                Account ToAccount = null;
                foreach (Account acc in accounts)
                    if (acc.AccID == ID)
                    {
                        ToAccount = acc;
                        break;
                    }

                Console.WriteLine("Enter Deposit Amount: ");
                decimal Amount = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Press S to Sumbit or Any Other Key to Exit: ");
                char Submit = Console.ReadKey().KeyChar;
                if (Submit == 's' || Submit == 'S')
                {
                    try
                    {
                        //validate ID and Amount
                        Validation.ValidateAccountID(ID, accounts);
                        Validation.ValidateAmount(Amount);
                        //call MonthlyDeposit method
                        ((Type2Acc)ToAccount).MonthlyDeposit = Amount;
                        Console.WriteLine("\n${0} will be deposited each month", Amount);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    flag = false;

                }
                else
                {
                    MainMenu();
                }
            }

        }
    }
}




