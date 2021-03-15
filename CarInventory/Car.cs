// Car.cs
// Author:  Sonadi Kannangara
// Date:    March 11, 2021
// Description:
//  A class designed to as a record of an individual car,
//  including a little information that describes their make, model, year, price.
using System;
using System.Collections.Generic;
using System.Text;

namespace CarInventory
{
    /// <summary>
    /// A class designed to as a record of an individual car, including some information that describes the car.
    /// </summary>
    class Car
    {
        // Static private variable to hold the number of cars.
        private static int carCount = 0;
        // Private variable to hold the identification number of cars.
        private int carIdentificationNumber= 0;
        // Private variable to hold the make of the car.
        private string carMake = String.Empty;
        // Private variable to hold the model of the car.
        private string carModel = String.Empty;
        // Private variable to hold the manufacture year of the car.
        private int carYear = 0;
        // Private variable to hold the price of the car.
        private decimal carPrice = 0;
        // Private variable to hold the status of the car.
        private bool carStatus = false;

        /// <summary>
        ///  Constructor - default - create a new car object.
        /// </summary>
        public Car()
        {
            carCount += 1;
            carIdentificationNumber = carCount;
        }

        /// <summary>
        /// Constructor - Parameterized - creates a new car object
        /// </summary>
        /// <param name="make"> make of the car </param>
        /// <param name="model"> model of the car </param>
        /// <param name="year"> manufacture year of the car </param>
        /// <param name="price"> price of the car </param>
        /// <param name="status"> status of the car </param>
        public Car(string make, string model, int year, decimal price, bool status) : this()
        {
            //carIdentificationNumber = id;
            // Set all of the instance variables within this class using the values
            // passed into this constructor.
            carMake = make; 
            carModel = model;
            carYear = year;
            carPrice = price;
            carStatus = status;
        }

        /// <summary>
        /// Count ReadOnly Property - Gets the number of cars that have been instantiated/created.
        /// </summary>
        public int Count
        {
            get
            {
                return carCount;
            }
        }

        /// <summary>
        /// IdentificationNumber ReadOnly Property - Gets a specific cars' identification number.
        /// </summary>
        public int Id
        {
            get
            {
                return carIdentificationNumber;
            }
        }

        /// <summary>
        /// NewStatus Property - Gets and Sets the new status of a car.
        /// </summary>
        public bool Status
        {
            get
            {
                return carStatus;
            }
            set
            {
                carStatus = value;
            }
        }

        /// <summary>
        /// Make Property - Gets and Sets the make of a car.
        /// </summary>
        public string Make
        {
            get
            {
                return carMake;
            }
            set
            {
                carMake = value;
            }
        }

        /// <summary>
        /// Model property - Gets and Sets the model of a car.
        /// </summary>
        public string Model
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
            }
        }

        /// <summary>
        /// Year property - Gets and Sets the year of a car.
        /// </summary>
        public int Year
        {
            get
            {
                return carYear;
            }
            set
            {
                carYear = value;
            }
        }

        /// <summary>
        /// Price property - Gets and Sets the price of a car.
        /// </summary>
        public decimal Price
        {
            get
            {
                return carPrice;
            }
            set
            {
                carPrice = value;
            }
        }

        /// <summary>
        /// GetCarData is a function that a salutation based on the private properties within the class scope.
        /// </summary>
        /// <returns></returns>
        public string GetCarData()
        {
            return "Car - " + carMake + " " + carModel + " " + carYear + ", " + (carStatus ? "New" : "Used");
        }
    }
}
