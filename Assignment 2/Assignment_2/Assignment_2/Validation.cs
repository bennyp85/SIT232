using System;
using System.Collections.Generic;
namespace Assignment_2
{
    public class Validation
    {
        public static void ValidateDOB(DateTime dob)
        {
            if (DateTime.Now.Year - dob.Year < 16)
                throw new Exception("Invalid DOB");
        }

        public static void ValidatePhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 10)
                throw new Exception("Invalid Phone Number");
        }

        public static void ValidateBalance(decimal Balance)
        {
            if (Balance <= 0)
                throw new Exception("You have no money");
        }

        public static void ValidateAccType(string AccType)
        {
            if (AccType != "1" || AccType != "2")
                throw new Exception("Not a valid account type");
        }

        public static void ValidateAccountID(uint ID, List<Account> accounts)
        {
            foreach (Account i in accounts)
            {
                if (i.AccID == ID)
                    return;
            }
            throw new Exception("No account with that ID");
        }

        public static void ValidateAmount(decimal Amount)
        {
            if (Amount <= 0)
                throw new Exception("Amount must be greater than 0");
        }
    }
}
