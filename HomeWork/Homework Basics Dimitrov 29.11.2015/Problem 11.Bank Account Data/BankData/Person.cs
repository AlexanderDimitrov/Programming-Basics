using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Bank_Account_Data.BankData
{
    internal class Person
    {
        private string firstName;
        private string secondName;
        private string thirdName;
        private int ballance;
        private string bankName;
        private int iban;
        public Person(CreditCard)
        {
            
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string SecondName
        {
            get { return this.secondName; }
            set { this.secondName = value; }
        }
        public string ThirdName
        {
            get { return this.thirdName; }
            set { this.thirdName = value; }
        }
        public int Ballance
        {
            get { return this.ballance; }
            set { this.ballance = value; }
        }
        public int IBAN
        {
            get { return this.iban; }
            set { this.iban = value; }
        }
        //Credit Cards
        internal class CreditCard
        {
            private int firstCard;
            private int secondCard;
            private int thirdCard;

            public CreditCarD(int FirstCard,int SecondCard,int ThirdCard)
            {
                this.FirstCard = firstCard;
                this.SecondCard = secondCard;
                this.ThirdCard = thirdCard;
            }

            public int FirstCard {
                get { return this.firstCard; }
                set { this.firstCard = value; } }
            public int SecondCard
            {
                get { return this.secondCard; }
                set { this.secondCard = value; }
            }
            public int ThirdCard
            {
                get { return this.thirdCard; }
                set { this.thirdCard = value; }
            }
            public override string ToString()
            {
                string separator = "+" + new string('-', 20) + "+" + new string('-', 50) + "+";
                StringBuilder output = new StringBuilder();
                output.AppendLine($"|{"First Card: ",-20}|{this.FirstCard,-50}|");
                output.AppendLine(separator);
                output.AppendLine($"|{"Second Card: ",-20}|{this.SecondCard,-50}|");
                output.AppendLine(separator);
                output.AppendLine($"|{"Third Card: ",-20}|{this.ThirdCard,-50}|");
                output.AppendLine(separator);
                return ToString(CreditCard);
            }
        }
    }
}

