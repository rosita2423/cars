using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    internal class Functions
    {
        //instance of date (today)
        License date = new License();

        //give people licenses and vehicles
        public void giveLicense(Person person, License license)
        {
            if (person.age >= 90) //age checker
            {
                Console.WriteLine("Sorry, we cannot provide an license to an old man :(");
            }
            else
            {
                if (person.firstLicense == true)
                {
                    person.receiveLicense(license);
                    license.keyCode = person.keyCode; //set the last parameter to license
                    person.firstLicense = false;
                    person.lastLicense = license.expirationDate;
                }
                else
                {
                    if (person.lastLicense > date.today) //compare to know if the licenses are able to change (parameter)
                    {
                        Console.WriteLine("You cannot activate a new license having one vigent :(");
                    }
                    else
                    {
                        person.receiveLicense(license);
                        person.lastLicense = license.expirationDate;
                    }
                }
                
            }
        }

        public void giveCar(Person person, Car car)
        {
            if (person.gender == "Girl")
            {
                if (car.color == "Red")
                {
                    person.receiveCar(car);
                }
                else
                {
                    Console.WriteLine("Girls don't like cars that aren't red :(");
                }
            }
            else
            {
                if(car.brand == "Ford" || car.brand == "Toyota")
                {
                    person.receiveCar(car);
                }
                else
                {
                    Console.WriteLine("The boys don't like others cars that aren't ford or toyota :(");
                }
            }
            if (person.carCounter() >= 5)
            {
                person.supiciousOfFraud = true;
            }
        }
    }
}
