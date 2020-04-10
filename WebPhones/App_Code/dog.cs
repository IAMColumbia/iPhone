using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{

    public class Mammal
    {

    }
    
    public class dog : Mammal
    {

        #region Private instance data members 

        private string name;
        private int age;
        private int speed;

        #endregion

        public string Name
        {
            get { 
                    return name; 
                }
            set { name = value; }
        }

        public int Age
        {
            get { 
                    return age; 
            }
        }
        
        public int Weight;
        public string BarkSound;

        public dog()
        {
            this.age = 0;
            this.BarkSound = "woof!!!!";
        }

        public string About()
        {
            string strAbout;
            strAbout = String.Format("{0} is named {1} and is {2} and weighs {3}", this.ToString(), this.name, this.age, this.Weight);
            return strAbout;
        }

        public void HappyBirthday()
        {
            this.age++;
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }

        public string Bark()
        {
            return this.BarkSound;
        }
    }
}
