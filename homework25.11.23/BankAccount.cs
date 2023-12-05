using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace homework25._11._23
{
    public class BankAccount
    {
        private static int Counter = 1001;
        protected decimal Balance { get; set; }
        private string type;
        public string Type
        {
            get
            {
                return type;
            }
        }
        private int account_number;
        public int AccountNumber
        {
            get
            {
                return account_number;
            }
        }
        private string account_holder;
        public string AccountHolder
        {
            get
            {
                return account_holder;
            }
            set
            {
                account_holder = value;
            }
        }
        protected static Queue<BankTransaction> history = new Queue<BankTransaction>();
        BankTransaction[] history_array = history.ToArray();

        private int SetAccountNumber()
        {
            return Counter++;
        }

        public BankAccount()
        {
            account_number = SetAccountNumber();

        }
        public BankAccount(decimal balance)
        {
            Balance = balance;
            account_number = SetAccountNumber();

        }

        public BankAccount(string type)
        {
            account_number = SetAccountNumber();
            this.type = type;
        }

        public BankAccount(decimal balance, string type)
        {
            Balance = balance;
            this.type = type;
            account_number = SetAccountNumber();
        }
        public BankAccount(decimal balance, string type, string holder)
        {
            Balance = balance;
            this.type = type;
            AccountHolder = holder;
            account_number = SetAccountNumber();
        }

        public void Print()
        {
            Console.WriteLine($"ID:{AccountNumber} \nBalance: {Balance} \nType: {Type}");
        }
        public void EmptyMoney(decimal sum)
        {
            if (sum > Balance)
            {
                Console.WriteLine("Unable to withdraw money. The requested amount exceeds the balance.");
            }
            else
            {
                Balance = Balance - sum;
                BankTransaction transaction = new BankTransaction(sum);
                history.Enqueue(transaction);
                Console.WriteLine($"Withdrawal: {sum} \nCurrent balance: {Balance}");
            }
        }

        public void MakeContribution(decimal sum)
        {
            if (sum < 0)
            {
                Console.WriteLine("Negative value. Impossible to contribute.");
            }
            else
            {
                Balance = Balance + sum;
                BankTransaction transaction = new BankTransaction(sum);
                history.Enqueue(transaction);
                Console.WriteLine($"Credited: {sum} \nCurrent balance: {Balance}");
            }
        }

        public void Dispose()
        {
            string file = "Transactions.txt";
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (BankTransaction transaction in history)
                {
                    writer.WriteLine($"Date and time: {transaction.DateTime} Sum: {transaction.Sum}");
                }
            }
            GC.SuppressFinalize(this);
        }

        protected BankTransaction this[int index]
        {
            get
            {
                if (index >= 0 || index < history_array.Length)
                    return history_array[index];

                else
                    throw new ArgumentOutOfRangeException("There is no bank transaction.");
            }
            set
            {
                if (index >= 0 || index < history_array.Length)
                {
                    history_array[index] = value;
                }
            }
        }
        [Conditional("DEBUG_ACCOUNT")]
        public void DumpToScreen()
        {
            Console.WriteLine($"Account number:{AccountNumber} \nOwner: {AccountHolder} \nType: {Type} \nBalance:{Balance}");
        }
    }
}
