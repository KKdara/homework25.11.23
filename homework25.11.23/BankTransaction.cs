using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework25._11._23
{
    public class BankTransaction
    {
        private DateTime date_time;
        public DateTime DateTime
        {
            get
            {
                return date_time;
            }
        }
        private decimal sum;
        public decimal Sum
        {
            get
            {
                return sum;
            }
        }

        public BankTransaction(decimal sum)
        {
            this.sum = sum;
            date_time = DateTime.Now;
        }
    }
}
