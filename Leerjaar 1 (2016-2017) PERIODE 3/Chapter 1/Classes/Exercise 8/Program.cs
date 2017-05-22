using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class UserStory
    {
        int Hours = 0;
        string Description = "";

        public UserStory(int hours, string description)
        {
            this.Hours = hours;
            this.Description = description;
        }    
           
        public int getHours
        {
            get
            {
                return Hours;
            }
            set
            {
                Hours = value;
            }
        }

        public string getDescription
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }

        public string ToString
        {
            get
            {
                string strHours = Hours.ToString();
                return strHours;
            }
        }

    }
}
