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
                Console.WriteLine("\n"+"--------- Sorry, we cannot provide an license to an old man :( -----------"+"\n");
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
                        Console.WriteLine("\n"+"----------- You cannot activate a new license having one vigent :( ------------"+"\n");
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
                    Console.WriteLine("\n"+"--------- Girls don't like cars that aren't red :( ----------"+"\n");
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
                    Console.WriteLine("\n"+"--------- PREFERENCE: The boys don't like others cars that aren't ford or toyota :( ------------"+"\n");
                }
            }
            if (person.carCounter() >= 5)
            {
                person.supiciousOfFraud = true;
            }
        }
        public void cancelCar(Person per, Car car)
        {
            if (car.type == "A")
            {
                //check the DATE VALIDATION and the SAME TYPE of the license comparing with the car
                if (per.licenseGet(per, "A") == true)
                {
                    if (per.quitCar(car) == true)
                    {
                        Console.WriteLine("Car " + car.brand + " quitted to " + per.name + " succesfully!");
                    }
                    else
                    {
                        Console.WriteLine("\n"+"------- Function error: Car " + car.brand + " didn't found on "+per.name+" to quit :( -----------" +"\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "-------- Function error: You cannot cancel "+car.brand+" without a valid license :( ------"+"\n");
                }
            }
            else if (car.type == "B")
            {
                if (per.licenseGet(per, "B") == true)
                {
                    if (per.quitCar(car) == true)
                    {
                        Console.WriteLine("\n"+"Car " + car.brand + " quitted to " + per.name + " succesfully!"+"\n");
                    }
                    else
                    {
                        Console.WriteLine("\n"+"------ Function error: Car" +car.brand +"didn't found on "+per.name+" to quit :( -------"+"\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n"+"-------- Function error: You cannot cancel car "+car.brand+" without a valid license :( ----------" + "\n");
                }
            }

            else if (car.type == "C")
            {
                if (per.licenseGet(per, "C") == true)
                {
                    if (per.quitCar(car) == true)
                    {
                        Console.WriteLine("\n" + "Car " + car.brand + " quitted to " + per.name + " succesfully!" + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\n" + "------ Function error: Car" + car.brand + "didn't found on " + per.name + " to quit :( -------" + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "-------- Function error: You cannot cancel car " + car.brand + " without a valid license :( ----------" + "\n");
                }
            }
            else
            {
                Console.WriteLine("\n"+"---------- There is a problem, you don't have that car-----------"+"\n");
            }

            
            
        }
    }
}
