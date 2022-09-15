﻿using cars;

internal class Program
{
    private static void Main(string[] args)
    {
        Functions function = new Functions();
        //Car instances
        Car chevy = new Car();
        chevy.year = new DateOnly(2022,10,11);
        chevy.brand = "Chevrolet";
        chevy.wheels = "Michelin";
        chevy.color = "Blue";
        chevy.description = "It have a dinosaur inside!";

        Car giantBus = new Car();
        giantBus.year = new DateOnly(2019, 07, 05);
        giantBus.brand = "Fate";
        giantBus.wheels = "Marca jorge";
        giantBus.color = "Yellow";
        giantBus.description = "A school bus xd";

        Car suru = new Car();
        suru.year = new DateOnly(2007, 02, 15);
        suru.brand = "Cesarin";
        suru.wheels = "IDK";
        suru.color = "Blue";
        suru.description = "The legendary vehicle of the cesarin's crew";

        Car tesla = new Car();
        tesla.year = new DateOnly(2015,05,12);
        tesla.brand = "Tesla";
        tesla.wheels = "Tesla wheels";
        tesla.color = "Gray";
        tesla.description = "Wow, you are a millionary!!!";

        Car to10 = new Car();
        to10.year = new DateOnly(2012,03,01);
        to10.brand = "Nissan";
        to10.wheels = "Michelin";
        to10.color = "Red";
        to10.description = "Why do girls like red cars?";



        //People instances

        Person person = new Person();
        Person user1 = person.createPerson(001,"Juancho","Valenzuela",19,"Boy");

        Person user2 = person.createPerson(002,"Moraman","Carlos",21,"Boy");
        function.giveCar(user2, chevy);

        Person user3 = person.createPerson(003,"Clarissa","Sanchez",22,"Girl");

        Person user4 = person.createPerson(004,"Toño","Ramirez",92,"Boy");

        Person user5 = person.createPerson(005,"Wario","Damian",18,"Boy");

        Person user6 = person.createPerson(006, "Victoria", "Hazenberg", 30, "Girl");
        function.giveCar(user6, to10);
        function.giveCar(user6, tesla);


        //Lincenses instances

        License license = new License();
        License A09 = license.createLicense("A", new DateOnly(2021, 05, 06), new DateOnly(2022, 05, 06));
        function.giveLicense(user4, A09);

        License A14 = license.createLicense("A", new DateOnly(2021, 12, 02), new DateOnly(2022, 12, 02));

        function.giveLicense(user2, A09);
        function.giveLicense(user2, A14);

        License B17 = license.createLicense("B", new DateOnly(2018, 12, 25), new DateOnly(2019, 12, 25));
        function.giveLicense(user3, A14);

        License c10 = license.createLicense("B", new DateOnly(2022, 08, 30), new DateOnly(2023, 12, 25));


        //Properties
        //User 1
        Console.WriteLine("----------User 1------------");
        person.printUserData(user1);
        user1.printLicenses();
        user1.printCars();
        Console.WriteLine("----------User 2------------");
        person.printUserData(user2);
        user2.printLicenses();
        user2.printCars();
        Console.WriteLine("----------User 3------------");
        person.printUserData(user3);
        user3.printLicenses();
        user4.printCars();
        Console.WriteLine("----------User 4------------");
        person.printUserData(user4);
        user4.printLicenses();
        user4.printCars();
        Console.WriteLine("----------User 5------------");
        person.printUserData(user5);
        user5.printLicenses();
        user5.printCars();
        Console.WriteLine("----------User 6------------");
        person.printUserData(user6);
        user6.printLicenses();
        user6.printCars();
    }
}