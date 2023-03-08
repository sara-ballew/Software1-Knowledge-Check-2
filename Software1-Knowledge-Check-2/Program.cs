using System;

namespace Software1_Knowledge_Check_2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Apartment>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var Apartment = new Apartment();

            Console.WriteLine("Enter the value for number of bedrooms");
            Apartment.Bedrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for number of bathrooms");
            Apartment.Bathrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for Garage? Y/N");
            Apartment.Garage = Console.ReadLine().ToLower() == "y" ? true : false;

            Console.WriteLine("Enter the value for square footage");
            Apartment.SquareFootage = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for lease length in months");
            Apartment.LeaseLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for which story is the apartment on");
            Apartment.StoryNumber = int.Parse(Console.ReadLine());


            recordList.Add(Apartment);
        }
        for (int i = 0; i < numberOfRecords; i++)
        {
            var Apartment = recordList[i];

            Console.WriteLine("Number of bedrooms: " + Apartment.Bedrooms.ToString());

            Console.WriteLine("Number of bathrooms: " + Apartment.Bathrooms.ToString());

            Console.WriteLine("Garage?: " + Apartment.Garage.ToString());

            Console.WriteLine("Square Footage of Apartment: " + Apartment.SquareFootage.ToString());

            Console.WriteLine("Length of Lease in Months: " + Apartment.LeaseLength.ToString());

            Console.WriteLine("Apartment Story: " + Apartment.StoryNumber.ToString());
        }


        // Print out the list of records using Console.WriteLine()


    }
}

