/*
* Name: Matthew Alan Alvis
* Course: CSCI 1250, Section 201
* Assignment: Lab 02, Trip Calculator
* Date: September 27, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/ 
System.Console.WriteLine(" ");
System.Console.WriteLine("=== Part 1: Road Trip ===");

Console.Write("Round trip miles: "); 
double tripMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("Miles per gallon: ");
double milePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per gallon: ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas: ");
double pizza = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per pizza: ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine(" ");

//Calculations for Part 1 and Part 2. Kind of just mixed themm together.

const double taxRate = .18;

string[] names = { "Ada", "Grace", "Alan", "Katherine" };
int peopleGoing = names.Length;

double[] hoursWorked = { 22,15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

const double slices = 8;
double totalPizzaSlices = slices * pizza;
double slicePerPerson = totalPizzaSlices /peopleGoing ;
double pizzaCost = pricePerPizza * pizza;

double gallonsNeeded = tripMiles / milePerGallon;
double fuelCost = FuelCost(tripMiles, milePerGallon, pricePerGallon);

double tripTotal = fuelCost + pizzaCost;

double costPerPerson = tripTotal / peopleGoing;

System.Console.WriteLine("=== Part 1: The Trip ===");
System.Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
System.Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
System.Console.WriteLine("Trip total: " + tripTotal.ToString("c"));
System.Console.WriteLine(" ");

//Part 2

System.Console.WriteLine("=== Part 2: The Group ===");

System.Console.WriteLine("People going: " + peopleGoing);
System.Console.WriteLine("Slices each: "  + slicePerPerson.ToString("F1"));
System.Console.WriteLine("Cost per person=: " + costPerPerson.ToString("C"));
System.Console.WriteLine(" ");

//Part 3

System.Console.WriteLine("=== Part 3: Who Works How Long ===");

System.Console.WriteLine(" ");

// double grossPay = hours * payRate;
// double taxWithheld = grossPay * taxRate;
// double takeHomePay = grossPay - taxWithheld;

// System.Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
// System.Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
// System.Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));
// System.Console.WriteLine(" ");

//Part 4

// double tripTotal = fuelCost + pizzaCost;
// double costPerPerson = tripTotal / 4;
// double payPerHour = takeHomePay / hours;
// double yourShare = costPerPerson / payPerHour;

// System.Console.WriteLine("=== Part 4: The Whole Trip ===");
// System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
// System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
// System.Console.WriteLine("Take home pay per hour: " + payPerHour.ToString("C"));
// System.Console.WriteLine("Hours you must work to cover your share: " + yourShare.ToString("F2"));
// System.Console.WriteLine(" ");

//I decided to keep what is uptop and to pull down what i will need
//After some thought i decided to just edit the stuff uptop. greying this out incase i decided to come back to it
/*
Console.Write("Round trip miles: "); 
double miles = Convert.ToDouble(Console.ReadLine());

Console.Write("Miles per gallon: ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per gallon: ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas: ");
double pizza = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per pizza: ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

const double taxRate = .18;

const double slices = 8;
double totalPizzaSlices = slices * pizza;
double slicePerPerson = totalPizzaSlices / 4;
*/
//I believe I finally got the methods working... cant wait for it to all mess up in part 2 or 3 lol
static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}
static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double payRate = hours * hourlyRate;
    return payRate * taxRate + payRate;
}
static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return amountOwed / takeHomePerHour;
}

//I don't know how i did it but i some how commited to lab 2 instead. couldnt figure out how to undo that so I copied the code, restarted and am now coing to commit to the right one this time