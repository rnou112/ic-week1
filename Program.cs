//// See https://aka.ms/new-console-template for more information
using SoftwareDev_Week1.Classes;

using SoftwareDev_Week1.Interfaces;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;



 
////LOOPS
LoopExample loopObject = new LoopExample();
loopObject.AddNumbersWithForLoop(10);


/*
 ////SWITCH
EvenOddNumbers objEvenOdd = new EvenOddNumbers();
objEvenOdd.NumberCheck();
*/

/*
Console.WriteLine("================================");
Console.WriteLine("======OOP Example===============");
Console.WriteLine("================================");

//// Create an instance of the ObjectOrientedEmployeeDemo class
ObjectOrientedEmployeeDemo employee = new ObjectOrientedEmployeeDemo();

//// Call the GetWage function and store the result in a variable
float wage = employee.GetWage();

//// Print the result to the console
Console.WriteLine("The wage of the employee is: " + wage);
*/

/*
Console.WriteLine("================================");
Console.WriteLine("=======Inheritance==============");
Console.WriteLine("================================");

Dog dog = new Dog();
dog.Name = "Roby";

Console.WriteLine(dog.Description);

dog.Bark();
*/

/*
Console.WriteLine("================================");
Console.WriteLine("=======Overload/Override========");
Console.WriteLine("================================");

//// example of Overload
///
OverloadExample example = new OverloadExample();
example.display(100);
example.display(100, 200);
*/

/*

//// example of Override 
BaseClass parent = new BaseClass();
parent.display();
*/


/// Static vs NonStatic
/*
Console.WriteLine(HelloWorldStatic.SayHello());

var nonStaticHello = new HelloWorldNonStatic();

Console.WriteLine(nonStaticHello.SayHello());
*/

//Abstract class use case
/*
Console.WriteLine("================================");
Console.WriteLine("========Abstract class==========");
Console.WriteLine("================================");
FullTimeEmployee fte = new FullTimeEmployee()
{
    ID = 101,
    FirstName = "John",
    LastName = "Doe",
    AnnualSalary = 60000
};

Console.WriteLine(fte.GetFullName());
Console.WriteLine(fte.GetMonthlySalary());


ContractEmployee cte = new ContractEmployee()
{
    ID = 102,
    FirstName = "Black",
    LastName = "Pink",
    HourlyPay = 100,
    TotalHoursWorked = 40
};

Console.WriteLine(cte.GetFullName());
Console.WriteLine(cte.GetMonthlySalary());
*/


Console.WriteLine("================================");
Console.WriteLine("==============EVENT=============");
Console.WriteLine("================================");
//// Event

UserService userService = new UserService();
EmailService emailService = new EmailService();

userService.UserRegistered += (sender, e) => emailService.SendWelcomeEmail(e.Email, e.Name);

userService.RegisterUser("johndoe@example.com", "John Doe"); 


/*
Console.WriteLine("================================");
Console.WriteLine("==============SOLID=============");
Console.WriteLine("================================");
//// Open close


 Shape objShape = new Rectangle(20, 30);
Console.WriteLine("Area of Rectangle: " + objShape.CalculateArea());

objShape = new Triangle(20, 30);
Console.WriteLine("Area of Triangle: " + objShape.CalculateArea());


objShape = new Circle(4);
Console.WriteLine("Area of Circle: " + objShape.CalculateArea());
*/

/*
IFruit fruit = new Orange();
Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
fruit = new Apple();
Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
*/

/*
Console.WriteLine("================================");
Console.WriteLine("============Extension===========");
Console.WriteLine("================================");
string s = "Hello Extension Methods";
int i = s.WordCount();
//int i = StringExtensions.WordCount(s);
Console.WriteLine(i);
*/

/*
Console.WriteLine("================================");
Console.WriteLine("=====Casting/Parsing/Convert====");
Console.WriteLine("================================");

//// parse
//string numberString = "1234 ";
// int parsedNumber = int.Parse(numberString);

// Console.WriteLine("parsedNumber is: "+ parsedNumber);

*/

/*
//// try parse
if (int.TryParse(numberString, out int number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Failed to parse string into int.");
}
*/
/*
int myInt = 9;
double myDouble = myInt; // Implicit casting: int to double
Console.WriteLine(myDouble);

myDouble = 9.78;
myInt = (int)myDouble; // Explicit casting: double to int
Console.WriteLine(myInt);

//// convert 
double myDouble2 = 9.48;
int myInt2 = Convert.ToInt32(myDouble2);
Console.WriteLine("Example of Convert: "+ myInt2);

*/

/*
Console.WriteLine("================================");
Console.WriteLine("============Var type============");
Console.WriteLine("================================");
var myInt1 = 5; // Implicitly typed as int
Console.WriteLine(myInt1.GetType());

var myDouble1 = 5.99; // Implicitly typed as double
int myInt2 = 5; // Integer (whole number)
float myFloat1 = 5.99F; // Floating point number (sufficient for storing 6 to 7 decimal digits)
double myDouble2 = 5.99D; // Floating point number (sufficient for storing 15 decimal digits)
List<String> list1 = new List<string>();
var list2 = new List<string>();
*/


/*
Console.WriteLine("================================");
Console.WriteLine("=========String concat==========");
Console.WriteLine("================================");

//// 1. "+" operator
string firstName = "John ";
string lastName = "Doe";
string name = firstName + lastName;
Console.WriteLine(name);

//// 2. "+=" operator
string str = "Hello";
//str = str + "World";
str += " World";
Console.WriteLine(str);

//// 3. string interpolation
string userName = "John";
string date = DateTime.Today.ToShortDateString();
string str1 = $"Hello {userName}. Today is {date}.";
string str2 = String.Format("Hello {0}. Today is {1}.", userName, date);
Console.WriteLine(str1);
Console.WriteLine(str2);

//// 4. Concat method
string name1 = string.Concat(firstName, lastName);
Console.WriteLine(name1);

//// 5. String builder
string firstName1 = "John ";
string lastName1 = "Doe";
StringBuilder builder = new StringBuilder();
builder.Append(firstName1);
builder.Append(lastName1);
Console.WriteLine(builder);
*/

/*
Console.WriteLine("================================");
Console.WriteLine("=========Exception==============");
Console.WriteLine("================================");

string numberString = null;
int nullNumber;

//// Using Convert.ToInt32()
nullNumber = Convert.ToInt32(numberString); // nullNumber = 0

// Using int.Parse()
try
{
    nullNumber = int.Parse(numberString); // Throws an exception
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

*/

//// Date handler
/*
string dateString = "2023-08-03";
DateTime dateTime = Convert.ToDateTime(dateString);
Console.WriteLine(dateTime);
*/
//Console.ReadLine();


//// example of basic operators
//Console.WriteLine("================================");
//Console.WriteLine("=========Basic operator=========");
//Console.WriteLine("================================");
//int a = 10;
//int b = 3;

//Console.WriteLine("a + b = " + (a + b)); // addition
//Console.WriteLine("a - b = " + (a - b)); // subtraction
//Console.WriteLine("a * b = " + (a * b)); // multiplication
//Console.WriteLine("a / b = " + (a / b)); // division
//Console.WriteLine("a % b = " + (a % b)); // modulus 



//Console.WriteLine("================================");
//Console.WriteLine("==============Loop==============");
//Console.WriteLine("================================");
//LoopExample loopClass = new LoopExample();
//loopClass.AddNumbersDoWhile(5);
//loopClass.AddNumbersWithForLoop(5);
//foreach (int number in loopClass.Numbers)
//{
//    Console.WriteLine(number);
//}


//Console.WriteLine("================================");
//Console.WriteLine("=========Data structure=========");
//Console.WriteLine("================================");
//// Stack
//TextEditor editor = new TextEditor();
//editor.SetText("Hello");
//Console.WriteLine(editor.Text);
//editor.SetText("Hello, World!");
//Console.WriteLine(editor.Text);
//editor.Undo();
//Console.WriteLine(editor.Text);
//editor.Redo();
//Console.WriteLine(editor.Text);

//// Queue
//// Create a new queue of strings
//Queue<string> myQueue = new Queue<string>();

//// Add some elements to the queue
//myQueue.Enqueue("apple");
//myQueue.Enqueue("banana");
//myQueue.Enqueue("cherry");

//// Peek at the first element of the queue
//Console.WriteLine("First element: " + myQueue.Peek());

//// Remove and print elements from the queue
//while (myQueue.Count > 0)
//{
//    string element = myQueue.Dequeue();
//    Console.WriteLine(element);
//} 


//Console.WriteLine("================================");
//Console.WriteLine("=========String Calculator==========");
//Console.WriteLine("================================");
//Calculator calculator = new Calculator();
//Console.WriteLine("Add: " + calculator.Add(1, 2));
//Console.WriteLine("Subtract: " + calculator.Subtract(1, 2));
//Console.WriteLine("Multiply: " + calculator.Multiply(1, 2));


//Console.WriteLine("================================");
//Console.WriteLine("=========employee List==========");
//Console.WriteLine("================================");

/*
using SoftwareDev_Week1.Classes;


//employees.Add(new Employee(123, "Joe", "Doe", new List<string> { "joe.doe@gmail.com" }, 21312));
//employees.Add(new Employee(111, "Alvin", "Park", new List<string> { "alv.par@gmail.com" }, 11312));
//employees.Add(new Employee(123, "King", "Tim", new List<string> { "kin.tim@gmail.com" }, 31312));

var employeeList = Helper.GetEmployees();
var result = employeeList.Where(e => e.ID == 111);
Console.WriteLine(result);
*/


Console.ReadLine();
