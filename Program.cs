using System;

namespace WaterBillCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************* Water Bill Calculator ****************");

            // Function to calculate water bill
            void CalculateWaterBill()
            {
                Console.WriteLine("Enter Customer's Name: ");
                string customerName = Console.ReadLine();

                Console.WriteLine("Enter the water meter reading of the previous month:");
                int previousReading = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the water meter reading of the current month:");
                int currentReading = Convert.ToInt32(Console.ReadLine());

                int consumption = currentReading - previousReading;

                Console.WriteLine("Enter the customer type:");
                Console.WriteLine("1. Household");
                Console.WriteLine("2. Administrative agency or public service");
                Console.WriteLine("3. Manufacturing unit");
                Console.WriteLine("4. Business service");
                int customerType = Convert.ToInt32(Console.ReadLine());

                double unitPrice = 0;
                double environmentFee = 0;

                switch (customerType)
                {
                    case 1: // Household
                        Console.WriteLine("Enter the number of household members:");
                        int numberOfMembers = Convert.ToInt32(Console.ReadLine());

                        double consumptionPerMember = (double)consumption / numberOfMembers;

                        if (consumptionPerMember <= 10)
                        {
                            unitPrice = 5.973;
                        }
                        else if (consumptionPerMember <= 20)
                        {
                            unitPrice = 7.052;
                        }
                        else if (consumptionPerMember <= 30)
                        {
                            unitPrice = 8.699;
                        }
                        else
                        {
                            unitPrice = 15.929;
                        }

                        environmentFee = unitPrice * 0.1;

                        break;

                    case 2: // Administrative agency or public service
                        unitPrice = 9.955;
                        environmentFee = unitPrice * 0.1;
                        break;

                    case 3: // Manufacturing unit
                        unitPrice = 11.615;
                        environmentFee = unitPrice * 0.1;
                        break;

                    case 4: // Business service
                        unitPrice = 22.068;
                        environmentFee = unitPrice * 0.1;
                        break;

                    default:
                        Console.WriteLine("Invalid customer type.");
                        return;
                }

                double totalAmount = consumption * unitPrice + environmentFee;

                // Display customer information
                Console.WriteLine("Customer Name: {0}", customerName);
                Console.WriteLine("Previous Meter Reading: {0}", previousReading);
                Console.WriteLine("Current Meter Reading: {0}", currentReading);
                Console.WriteLine("Consumption: {0}", consumption);
                Console.WriteLine("Total Water Bill: {0} VND", totalAmount);
            }

            // Run the water bill calculation program
            CalculateWaterBill();
        }
    }
}
