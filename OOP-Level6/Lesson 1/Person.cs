using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    //class: is a template that defines an entity structure. An entity (usually) represents a real-life 
    //model . object which is described using characteristics
    // use Pascal casing for class names
    //field: is a variable which describes something about the model/object
    //: use camel casing for field names
    //{get; set;} - is a property it contrils the accessibility to the fields from other fields - declares public - It can have only a get or a set

    class Person
    {
        string idCardNo;
        private string name;
        string surname;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string IdCard
        {
            get { return idCardNo; }
            set
            {
                switch (value.ToString().Length)
                {
                    case 5:
                        idCardNo = "00" + value;
                        break;
                    case 6:
                        idCardNo = "0" + value;
                        break;
                    default:
                        idCardNo = value.ToString().ToUpper();
                        break;

                }
                idCardNo = value.ToString().ToUpper();
            } //useful as it prevents from data not matching the requiresment etc
        }

        public string FullName //it doesn't need a set{} as it is a read only property - no need to set anything as they are being set in sepr fields
        {
            get { return Name + " " + Surname; }
        }

        public string Surname { get => surname; set => surname = value; }

        public string Address { get; set; } //taking a shortcut - instead of declaring the var first as a field just create a property.
        public string MobileNo { get; set; }
        public string TelNo { get; set; }

        public DateTime DOB { get; set; }
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            return today.Year - DOB.Year;
        }

        public string DelimitAddress(char c)
        {
            string[] delimitedAddress = Address.Split(new char[] { ' ' });
            string output = "";
            foreach (string s in delimitedAddress)
            {
                output += s + c + "";
            }
            return output.Remove(output.Length - 2);
        }

    }
}
