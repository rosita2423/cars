using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    internal class Person
    {
        //Attributes of person
        public int keyCode { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        List<License> licenseSet = new List<License>();
        List<Car> carSet = new List<Car>();
        public bool supiciousOfFraud = false;

        //License first time check
        public bool firstLicense = true;

        //Last license
        public DateOnly lastLicense { get; set; }
        
        //Varible to count
        private int counter = 0;
        private int counterCar = 0;

        //Methods
        public void receiveLicense(License licenseMethod)
        {
            licenseSet.Add(licenseMethod);
        }
        public void receiveCar(Car carMethod)
        {
            carSet.Add(carMethod);
        }
        public int carCounter()
        {
            counterCar = carSet.Count;
            return counterCar;
        }

        public Person createPerson(int keyCodeParameter, string NameParameter, string surNameParameter, int ageParameter, string genderParameter)
        {
            Person personTuned = new Person();
            personTuned.keyCode = keyCodeParameter;
            personTuned.name = NameParameter;
            personTuned.surname = surNameParameter;
            personTuned.age = ageParameter;
            personTuned.gender = genderParameter;
            return personTuned;
        }


        //Printer functions
        public void printUserData(Person people)
        {
            Console.WriteLine("Key Code: " + people.keyCode + "\n" +
                "Name: " + people.name + "\n"+
                "SurName: "+people.surname + "\n"+
                "Age: "+ people.age +"\n"+
                "Gender: "+people.gender+"\n");
        }
        public void printLicenses()
        {
            counter = 0;
            foreach (License license in licenseSet)
            {
                counter++;
                Console.WriteLine("Type: " + license.type + "\n" + "Initial Date: " + license.initialDate + "\n");
            }
        }

        public void printCars()
        {
            counter = 0;
            foreach (Car car in carSet)
            {
                counter++;
                Console.WriteLine("Car Number " + counter + "\n" +"Brand: " + car.brand + "\n" + "Year :" + car.year + "\n" + "Wheels: " + car.wheels + "\n" +"Color: " + car.color + "\n" + "A brief description : " + car.description + "\n");
            }
        }

    }
}
