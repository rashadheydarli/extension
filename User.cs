using System;
namespace extensionmethod
{
	public class User
	{
		public int pin;

		public string Name { get; set; }
		public string Surname { get; set; }
		public RegistrationMonth RegistrationMonth { get; set; }
		public int PIN
		{
			get
			{
				return pin;
			}
			set
			{ 
				if (value.Length == 7)
				{
					pin = value;
				}
				else
				{
					throw new Exception("Duzgun deyil");
				}
			}
		}
		public User( int pin)
		{
			this.pin = pin;
		}
        public static string GetDetail(this int pin,string name, string surname, int registrationmonth )
        {
            return $"Name: {name}\n Surname: {surname}\n Reg.Month: {registrationmonth}\n Pin: {pin}";

        }
    }

	enum RegistrationMonth
	{
			January=1,
			February, 
			March,
			April, 
			May ,
			June ,
			July ,
			August,
			September, 
			October ,
			November ,
			December 
    }
}

