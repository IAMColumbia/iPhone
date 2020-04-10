using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPhoneNoInterface
{
    public class PhoneNumber
    {
        //Private Instatnce Data Members
        protected int areaCode;
        protected int exchange;
        protected int number;

        //Accessor
        public int AreaCode { get { return this.areaCode; } }
        public int Exchange { get { return this.exchange; } }
        public int Number { get { return this.number; } }

        public string PhoneNum { get { return string.Format("({0}){1}-{2}", this.areaCode, this.exchange, this.number); } }

        public PhoneNumber(int PhoneAreaCode, int PhoneExchange, int PhoneNum)
        {
            this.areaCode = PhoneAreaCode;
            this.exchange = PhoneExchange;
            this.number = PhoneNum;
        }

        public PhoneNumber(string s)
        {

            if (s.Length > 3)
            {
                try
                {
                    this.areaCode = int.Parse(s.Substring(0, 3));
                }
                catch
                {
                    this.areaCode = 0;
                }
            }
            else
            {
                this.areaCode = 0;
            }
            if (s.Length > 5)
            {
                string sexhange = s.Substring(3, 3);
                try
                {
                    this.exchange = int.Parse(sexhange);
                }
                catch
                {
                    this.exchange = 0;
                }
            }
            else
            {
                this.areaCode = 0;
            }
            if (s.Length >= 10)
            {
                string snum = s.Substring(6, 4);
                try
                {
                    this.number = int.Parse(snum);
                }
                catch
                {
                    this.number = 0;
                }
            }
            else
            {
                this.areaCode = 0;
            }
        }


    }
}
