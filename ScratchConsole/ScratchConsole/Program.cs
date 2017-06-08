using ScratchConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace: Virtual container for related classes; similar to Java Packages
namespace ScratchConsole
{

    #region Sprocket
    //public class Sprocket
    //{
    //    public int teethCount = 0;

    //    public Sprocket(int teetchCount)
    //    {
    //        this.teethCount = teetchCount;
    //    }
    //}
    #endregion

    #region Ducks
    //All methods of an interface are considered abstract
    public interface IDuckable
    {
        void Quack();
    }

    //In order to have abstract members, a CLASS msut be abstract
    public abstract class Duck : IDuckable
    {
        public string DuckType { get; set; }

        //A method that is neither virtual nor abstract CANNOT be overridden
        public void PrintType()
        {
            Console.WriteLine($"I'm a {DuckType} duck!");
        }

        //An abstract method MUST be overriden
        public abstract void Fly();

        //A virtual method MAY be overriden
        public virtual void Quack()
        {
            Console.WriteLine("Quack quack");
        }
    }

    public class RubberDucky : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("The child throws the rubber ducky an impressive and annoying distance.");
        }

        public override void Quack()
        {
            Console.WriteLine("Squeek squeek skeep bob");
        }
    }

    public class Doctor : IDuckable
    {
        public void Fly()
        {
            Console.WriteLine("The doctor flies United... but then suddenly and against his will doesn't.");
        }

        public void Quack()
        {
            Console.WriteLine("Damn it, Jim, I'm a doctor not a duck");
        }
    }

    public class Mallard : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("Fly majestically.. and better than any other duck.");
        }

        public override void Quack()
        {
            Console.WriteLine("The mallard quacks like an eagle.");
        }
    }
    #endregion

    #region Protected Demo
    public class Parent
    {

        public string Name { get; protected set; }

        public Parent(string name)
        {
            Name = name;
        }
    }

    public class Child : Parent
    {

        public Child(string name) : base(name)
        {

        }

        public void ChangeName()
        {
            Name = "Topanga";
        }

    }
    #endregion

    public class Program
    {
        public static Random rand = new Random();

        #region Random Out Of Class Stuff
        #region Review List 10April2017
        /*
         *Review List 
         * 1. Random Num Gen (^)
         * 2. Using Enums in C# (^)
         * 3. Using Arrays (^)
         * 4. Using Ctors
         * 5. Value type vs Reference type (^)
         * 
         */
        #endregion

        #region Primitive Data Types
        //Primitive Data Types
        //Integrals
        //byte b;
        //short s;
        //int i;
        //long l;

        ////Floating-points
        //float f;
        //double d;
        //decimal dec;

        ////Non-numeric
        //bool bl;
        //char c;
        #endregion

        #region UpdatePersonName
        //public static void UpdatePersonName(Person p, string newName)
        //{
        //    //As long as newName is neither null nor empty, assign it to the name field of the Person instance
        //    if (p != null)
        //    {
        //        if (!string.IsNullOrEmpty(newName))
        //        {
        //            p.name = newName;
        //        }
        //    }
        //}
        #endregion

        #region UpdateNumber
        //public static void UpdateNumber(int x)
        //{
        //    //If x is positive, increase its value by 10
        //    //If x is negative, decrease its value by 17
        //    if (x > 0)
        //    {
        //        x += 10;
        //    } else if (x < 0) 
        //    {
        //        x -= 17;
        //    }
        //    Console.WriteLine("X = " + x);
        //}
        #endregion
        #endregion

        public static void Run()
        {



            #region Delegates
            //HeadlineNotifier helen = new HeadlineNotifier();

            ////Subscribe to a delegate:
            //helen.HeadlineDelegate += ClassicNewsAnchor.BragAboutNews;
            ////helen.HeadlineDelegate += MillenialNewsBlogger.PostStory;
            //MillenialNewsBlogger.TrustNewsSoruce(helen);
            //helen.HeadlineDelegate += Stoner.Dude;

            ////Unsubscribe from a delegate:
            //helen.HeadlineDelegate -= Stoner.Dude;

            //do
            //{

            //    Console.Write("\nEntre a new Headline: ");
            //    helen.Headline = Console.ReadLine();

            //} while (!string.IsNullOrEmpty(helen.Headline));
            #endregion

            #region Interfaces & Ducks
            /*
             * Interfaces
             * What they do: 
             * 1. They are abstract
             * 2. They create a contract, a guarantee
             *      All members of an interface appear in the concrete implementation
             * 
             * What they don't:
             * 1. Contain any implementation 
             * 2. Guarantee the implementation is useful
             * 3. Stop a class from having MORE members
             * 4. Allow you to create an instance of a type
             * 
             * Abstract:
             * Virtual - you _may_ override
             * Abstract - you _must_ override
             * (sealed)/[none] - you _can't_ override
             */

            //Create and store one instance of each concrete IDuckable class
            //Do This Using One Array
            //Pro Tip: Using/implementing interfaces grants us polymorphism
            //Then, call each IDuckable method through each instance using a foreach loop
            //Duck duckington = new Duck();
            //RubberDucky rubberDucky = new RubberDucky();
            //Doctor sorryDoc = new Doctor();
            //Console.WriteLine(sorryDoc.GetType().Name + ":");
            //sorryDoc.Fly();
            //sorryDoc.Quack();
            //Console.WriteLine();
            //Console.WriteLine(duckington.GetType().Name + ":");
            //duckington.Fly();
            //duckington.Quack();
            //Console.WriteLine();
            //Console.WriteLine(rubberDucky.GetType().Name + ":");
            //rubberDucky.Fly();
            //rubberDucky.Quack();
            //List<IDuckable> ducks = new List<IDuckable>()
            //{

            //    new Duck()
            //    {

            //    },

            //    new Doctor()
            //    {

            //    },

            //    new RubberDucky()
            //    {

            //    },

            //    new Mallard()
            //    {

            //    }
            //};

            //foreach (IDuckable d in ducks)
            //{
            //    Console.WriteLine(d.GetType().Name + ":");
            //    d.Fly();
            //    d.Quack();
            //    Console.WriteLine();
            //}
            #endregion

            #region Student & Fac
            //This is called Polymorphism
            //Person student = new Student();
            //Person faculty = new Faculty();
            //Person person = new Person();

            //List<Person> people = new List<Person>()
            //{

            //new Person("BobDillinger")
            //{
            //    BirthDate = DateTime.Now,
            //    IsMarried = true,
            //    SSN = "777-77-BOPP"
            //},  

            //new Student("Jack Bauer")
            //{
            //    StudentID = 24,
            //    BirthDate = new DateTime(2001, 2, 24),
            //    SSN = "024-24-2424",
            //    IsMarried = false,
            //    IsEnrolled = true,
            //    CummulativeGPA = 2.4f
            //},

            //new Faculty("Master Krebs", true)
            //{
            //    EmployeeID = 1337,
            //    BirthDate = new DateTime(1978, 12, 27),
            //    SSN = "197-81-2270",
            //    IsMarried = true,
            //    DateOfHire = new DateTime(2012, 9, 17),
            //    AnnualSalary = 48225.05f
            //}
            //};

            //PersonMaker(people);

            //Parent -> Child
            //Base -> Derived
            //Super -> Sub
            //Generalized -> Specialized
            //All in Models Folder
            #endregion

            #region MoreInRun
            #region Dictionary
            ////Create a dictionary that tracks population count by city name
            //Dictionary<string, int?> popByCity = new Dictionary<string, int?>();

            ////Add "Modesto" with a population of 204933
            //popByCity["Modesto"] = 204933;
            //popByCity["Salt Lake City"] = 356198;
            //popByCity["Sandy"] = 124632;
            //popByCity["TriggerVille"] = 3;

            //Dictionary<string, int?>.KeyCollection keys = popByCity.Keys;

            ////Print out each key and its corresponding value to the console
            //foreach (string key in keys)
            //{
            //    Console.WriteLine("{0, -15}{1, 15:n0}", key, popByCity[key]);
            //}
            #endregion

            #region 2D Arrays
            //Declaring and initializing an array
            //int[] sdNums = new int[10];
            ////2D array: An array of arrays of ints, Delairing and initializing a 2d array
            //int[,] tdNums = new int[10,14]; 

            ////Write the code that fills tdNums sequentially with ints starting at 1
            //for (int i = 0; i < tdNums.GetLength(0); i++)
            //{
            //    for (int s = 0; s < tdNums.GetLength(1); s++)
            //    {
            //        //Fill in 2D array without a counter
            //        tdNums[i, s] = ((s + 1 ) + (i * tdNums.GetLength(1)));
            //        Console.Write(tdNums[i,s] + ", ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Try-Catches
            //Write separate catch statements for each exceptions int.Parse can throw
            //try
            //{
            //    //Throwing and Catching Exceptions
            //    Console.Write("Entre an int: ");
            //    string input = Console.ReadLine();
            //    int num = int.Parse(input);
            //}
            //catch (FormatException e)
            //{
            //    throw new FormatException("You entred a value that is not an int.");
            //}
            //catch (ArgumentNullException ae)
            //{
            //    throw new ArgumentNullException("Your input must not be null.");

            //}
            //catch (OverflowException oe)
            //{
            //    throw new OverflowException("Your input must be within the limits of an int.");
            //}
            #endregion

            #region Recursion
            //Console.Write("Please enter a message: ");
            //string input = "Meow meow, I'm a cow";
            //int x = input.Length;
            //Console.WriteLine(ReverseString(input, x));
            //int num1 = 2;
            //int num2 = 3;
            //int num3 = 4;
            //IncrementSum(num1, num2);
            //Console.WriteLine(IncrementSum(num1, num2));
            //Console.WriteLine(Summation(num3));
            #endregion

            #region CIO Tester
            //CIO.PromptForBool("Do You Like Cows? (1/2)", "1", "2");
            //CIO.PromptForByte("Please entre a number between these two numbers: ", 1, 5);
            //CIO.PromptForShort("Please entre a number between these two numbers: ", 1, 5);
            //CIO.PromptForInt("Please entre a number between these two numbers: ", 1, 5);
            //CIO.PromptForLong("Please entre a number between these two numbers: ", 1, 5);
            //CIO.PromptForFloat("Please entre a number between these two numbers: ", (float)1.5, (float)3.5);
            //CIO.PromptForDouble("Please entre a number between these two numbers: ", 1.5, 3.5);
            //CIO.PromptForChar("Please enter a character between these two charcters: ", 'a', 'b');
            //CIO.PromptForInput("Please input a message: ", false);
            #endregion

            #region Array and Lists
            ////Delcare and instantiate array of 1337 ints
            //int[] winner = new int[1337];

            ////Declare and instantiate a List of ints
            //List<int> numList = new List<int>();

            ////Print the current count of elements in the List
            //Console.WriteLine("Count: " + numList.Count);

            ////Add a value to the List
            //numList.Add(21);
            //Console.WriteLine("Count: " + numList.Count);

            ////Add 5 numbers of your choice to the List
            //numList.Add(41);
            //numList.Add(9);
            //numList.Add(24);
            //numList.Add(4311);
            //numList.Add(91);
            //Console.WriteLine("Count: " + numList.Count);

            ////Removing a number from the List
            //numList.Remove(24);
            //Console.WriteLine("Count: " + numList.Count);
            //Console.WriteLine();

            ////Print each element in the List on its own line
            //foreach (int beep in numList)
            //{
            //    Console.WriteLine(beep);
            //}
            //Console.WriteLine();

            ////Print the element that is 3rd in the List
            //Console.WriteLine(numList.ElementAt(2));
            ////Or
            //Console.WriteLine(numList[2]);

            #endregion

            #region List To String Printing
            //Prompt the user for the number of ints to be created
            //Using the proper loop, create and populate a List<int> with that many values
            //Random values should be between 1 and 100 inclusive

            //bool valid = false;
            //int userNum = 0;

            //do
            //{
            //    Console.Write("Enter a number: ");
            //    string input = Console.ReadLine();
            //    Console.WriteLine();
            //    valid = int.TryParse(input, out userNum) && 1 <= userNum;
            //    if (!valid)
            //    {
            //        Console.WriteLine("Please entre a valid input.");
            //        Console.WriteLine();
            //    }
            //} while (!valid);

            //List<int> userList = new List<int>();
            //Random rand = new Random();
            //for (int i = 0; i < userNum; i++)
            //{
            //    userList.Add(rand.Next(1, 101));
            //}

            //string listString = MakeStringFromList(userList);
            //Console.WriteLine(listString);
            #endregion

            #region Random Number
            //Pick Random number between 1 & 10 inclusive
            //int num = rand.Next(10) + 1;
            //Console.WriteLine(num);
            #endregion

            #region Person Making and Changing
            //Give the new Person object a random age between 7 & 128
            //int randAge = rand.Next(7, 129);

            //Randomly give the Person a name
            //string[] names = { "Aderyn", "Topa", "Jen", "Ronny", "Hana", "Anna", "Bearisa", "Chell" };
            //int i = rand.Next(names.Length);
            //string randName = names[i];

            //Create an Instance of Person
            //Person p = new Person(randAge, randName);
            //Console.WriteLine(p.ToString());

            //UpdatePersonName(p, "Jen");
            //Console.WriteLine(p.ToString());

            //Console.WriteLine();

            //int num = 12;
            //Console.WriteLine("Num: " + num);
            //UpdateNumber(num);
            //Console.WriteLine("Num: " + num);

            //Console.WriteLine();

            //Console.WriteLine("Person's Age: " + p.age);
            //UpdatePersonAge(p);
            //Console.WriteLine("Person's Age: " + p.age);
            #endregion

            #region Giving Person Age
            //Prompt the user for their age
            //Age must be between 1 and 128
            //If age input is invalid for ANY reason, tell the user, Prompt again
            //int age = 0;
            //bool valid = false;
            //do
            //{
            //    Console.Write("Please entre your age: ");
            //    string userInput = Console.ReadLine();
            //    valid = int.TryParse(userInput, out age) && 1 <= age && age <= 128;

            //    if (!valid)
            //    {
            //        Console.WriteLine("You must entre a number between 1 and 128 inclusive.");
            //    }

            //} while (!valid);
            #endregion

            #region New Person
            //Person p = new Person(24, "Jen", 115);

            //Console.WriteLine(p.ToString()); 
            #endregion
            #endregion
        }

        #region Stuff In Program
        #region StaticPersonPrinter
        //Create a static method that takes in a collection of people and prints each one to the console
        //public static void PersonMaker(IEnumerable<Person> people)
        //{
        //    foreach (Person person in people)
        //    {
        //        Console.WriteLine(person + "\n");
        //    }
        //}
        #endregion

        #region ReverseMsgRecursion
        //Create a Method that takes in a string, then uses recursion to return the string in reverse
        //No, you cannot call the built-in Reverse method
        //public static string ReverseString(string reversemsg, int i)
        //{
        //    i--;
        //    char msg = reversemsg[i];
        //    if (i > 0)
        //    {
        //        ReverseString(reversemsg, i);
        //    }
        //    return reversemsg;
        //}
        #endregion

        #region IncrementSumRecursion
        //Create a Method that takes in two ints and, using recursion and single incrementation, returns
        //the sum of the two ints
        //public static int IncrementSum(int x, int y)
        //{
        //    if (x < 0 || y < 0)
        //    {
        //        throw new ArgumentException("Your x and y arguments must be greater than or equal to 0.");
        //    }
        //    int sum = x;

        //    if (y > 0)
        //    {
        //        x++;
        //        y--;
        //        //Console.WriteLine(x);
        //        sum = IncrementSum(x, y);
        //    }
        //    return sum;
        //}
        #endregion

        #region SumationRecursion
        //public static int Summation(int n)
        //{
        //    //n >= 0 // Input Boundaries
        //    //f(n) = n + f(n-1) // Recursive function itself
        //    //f(0) = 0 // Base Case/Terminal Case
        //    int sum = 0;
        //    if (n < 0)
        //    {
        //        throw new ArgumentException("Your input must be greater than or equal to 0.");
        //    }

        //    if (n == 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        sum = n + Summation((n - 1));
        //        return sum;
        //    }
        //}
        #endregion

        #region StringList
        //Create a method that takes in a List<int> and returns a string of the ints where each line has at most 5 values
        //public static string MakeStringFromList(List<int> theListOfInts)
        //{
        //    StringBuilder retVal = new StringBuilder();
        //    int count = 0;
        //    foreach (int num in theListOfInts)
        //    {
        //        if(count == 5)
        //        {
        //            count = 0;
        //            retVal.Append("\n");
        //        }
        //        retVal.Append(num);
        //        retVal.Append("\t");
        //        count++;
        //    }

        //    return retVal.ToString();
        //}
        #endregion

        #region ChangePerson Age
        //public static void UpdatePersonAge(Person p)
        //{
        //    if (p != null)
        //    {
        //        p.age += 5;
        //        Console.WriteLine("Person's Updated Age: " + p.age);
        //    }
        //}
        #endregion

        #region Person Class
        //public class Person
        //{
        //    private int age;
        //    private string name;
        //    private float weight;

        //This is what the default ctor looks like when you don't define one..~
        //public Person()
        //{

        //}

        //Ctor overload
        //public Person(int age, string name, float weight)
        //{
        //    this.age = age;
        //    this.name = name;
        //    this.weight = weight;
        //}

        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

        //public string ToString()
        //{
        //    return "Name: " + name + ", Age: " + age + ", Weight: " + weight;
        //}
        //}
        #endregion
        #endregion

        public static void Main(string[] args)
        {
            Run();

            #region TooMuchInMain
            #region Int Sum
            //Declare and initialize two int variables
            //Add the two ints together
            //Print the result
            //int t = 19;
            //int e = 18;
            //Console.WriteLine(t + e);
            #endregion

            #region Today's Day
            //Prompt the user for the name of today
            //Print out the message "Today is " and then the user's input

            //Console.WriteLine("What day of the week is today?");
            //string today = Console.ReadLine();
            //Console.WriteLine("Today is " + today);
            #endregion

            #region Name
            //Prompt the user for their name
            //Print a sarcastic response denoting their name with quotes
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Okay \"" + name + "\" sure~");
            #endregion

            #region TestCode
            //string[] temp = null;
            //string input = Console.ReadLine();
            //Console.WriteLine(length);
            #endregion

            #region Int[]
            //Declare and initialize an int[] of size 24 
            //Populate each index of this array with a random value between 1 - 36 inclusive
            //Call MultiplyNumbers passing in your array
            //Print result

            //Random rand = new Random();

            //int[] nums = new int[24];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = rand.Next(36) + 1;
            //    Console.WriteLine(nums[i]);
            //}

            //long result = MultiplyNumbers(nums);

            //Short Version -> Console.WriteLine(MultiplyNumbers(nums));

            //Console.WriteLine(result);
            #endregion

            #region Prompt User Int[] + Random
            ////Prompt the user for how many numbers they would like
            //Console.Write("How many numbers would you like?: ");
            //string input = Console.ReadLine();

            ////Prompt the user two times, once for the min and again for the max of the random int values for the array inclusive
            //Console.Write("What would you like the min value to be?: ");
            //string min = Console.ReadLine();

            //Console.Write("What would you like the max value to be?: ");
            //string max = Console.ReadLine();

            ////Parase the input ot an int (FormatExceptions do not need to be caught.. yet)
            ////Java: Integer.parseInt(input);
            ////C# is similar..
            //int userNum = int.Parse(input);
            //int mini = int.Parse(min);
            //int maxi = int.Parse(max);

            ////Declare and initialize (without explicit values) an array equal in size to the user's input
            //int[] numbers = new int[userNum];

            ////Populate array using PopulateArray method
            //Populate(numbers, mini, maxi);

            ////Print Array
            //Print(numbers);
            #endregion

            #region Print Teeth Count
            //Console.WriteLine();
            //Console.WriteLine("Teeth Count");

            //Sprocket s = new Sprocket(24);
            //Console.WriteLine(s.teethCount);
            //Demo(s);
            //Console.WriteLine(s.teethCount);
            #endregion

            #region Reverse Message
            //Prompt the user for a string
            //Console.Write("Please Entre A Message: ");
            //string message = Console.ReadLine();
            //char[] revmesg = message.ToCharArray();
            //Array.Reverse(revmesg);

            //Print the string in reverse with each character on its own line
            //foreach (char mesg in revmesg)
            //{
            //    Console.WriteLine(mesg);
            //}

            //for (int i = message.Length - 1; i > -1; i--)
            //{
            //    Console.WriteLine(message[i]);
            //}
            #endregion

            #region StringBuilder
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello");
            //sb.Append(" World");
            //Console.WriteLine(sb.ToString());
            #endregion

            #region Prompt User For Name
            //Prompt the user for their name, but make sure they enter something
            //bool valid = false;
            //do
            //{
            //    Console.Write("Please entre your name: ");
            //    string name = Console.ReadLine();
            //    if (name == null || name == "")
            //    {
            //        Console.WriteLine("Please entre a valid input.");
            //    } else
            //    {
            //        Console.WriteLine("'Ello love! The calvary is here for you, " + name + "." );
            //        valid = true;
            //    }

            //} while (!valid);
            #endregion
            #endregion
        }

        #region StuffOutside
        #region PrintInts
        //Create a method that takes in an int array and prints each value on its own line

        //public static void Print(int[] numbers)
        //{
        //    //for (int i = 0; i < numbers.Length; i++)

        //    //For-each loop
        //    //JAAAva For-each loop: for (int number : nums)
        //    //C$harp For-each loop:
        //    foreach(int number in numbers)
        //    {
        //        Console.WriteLine(number);
        //    }
        //}
        #endregion

        #region Populate Array
        //Create a method that takes in an int array and populates it with random values between -100 and 100 inclusive.
        //All arrays are reference~
        //Make sure not to break when nums is null
        //public static void Populate(int[] numbers, int mini, int maxi)
        //{

        //    //Turnarry
        //    //nums = nums != null ? nums : new int[0]; <- If nums = null then it is initialized, else it states the same.

        //    //Cournarry
        //    //numbers = numbers ?? new int[0]; <-Only use if null.. Changes initialization of nums if null.

        //    if (numbers != null)
        //    {
        //        Random rand = new Random();

        //        for (int i = 0; i < numbers.Length; i++)
        //        {
        //            numbers[i] = rand.Next(mini, maxi + 1);
        //        }
        //    }
        //    //else
        //    //{
        //    //    Console.WriteLine("Error on Populate; numbers cannot be null.");
        //    //}
        //}
        #endregion

        #region Sprocket Demo
        //public static void Demo(Sprocket x)
        //{
        //    x.teethCount += 7;
        //    Console.WriteLine(x.teethCount);
        //}
        #endregion

        #region MultiplyNumbers Array
        //public static long MultiplyNumbers(int[] nums)
        //{
        //return the product of these numbers
        //int startingPoint = nums.Length;
        //long product = 1;

        //while (startingPoint != 0)
        //{
        //    product *= nums[--startingPoint];
        //}

        //for (int s = 0; s < nums.Length; s++)
        //{
        //    product *= nums[s];
        //}

        //return product;
        //}
        #endregion
        #endregion
    }
}


