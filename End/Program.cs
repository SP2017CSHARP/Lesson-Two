using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Answers to homework

            ////HomeWork 1
            //Console.Write("Please write first number: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please write second number: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please write second number: ");
            //int n3 = Convert.ToInt32(Console.ReadLine());

            //if (n1 == n2 && n2 == n3)
            //{
            //    Console.WriteLine("All three numbers are equal");
            //}

            ////Conditions 3
            //Console.WriteLine("Please write you first name:");
            //string fName = Console.ReadLine();
            //Console.WriteLine("Please write your Last name:");
            //string lName = Console.ReadLine();
            //Console.WriteLine("Please write your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //// fullname.Contains(" ");
            //if (fName != "" && lName != "" && age > 18)
            //{
            //    Console.WriteLine("Great Job!");
            //}

            ////Conditions 4
            //Console.WriteLine("Write text:");
            //string text = Console.ReadLine();
            //if (text.Contains("ä") || text.Contains("ö") || text.Contains("å"))
            //{
            //    Console.WriteLine("Tjena kompis!");
            //}
            //else
            //{
            //    Console.WriteLine("Hello there fellow american");
            //}



            #endregion

            #region Warm Up

            //Warm up assignment: 
            //Ask a user to choose whether they have a dog or a cat. IF they have a cat/dog; ask them what their
            //cats name or dogs name is then have the program repeat it to them at the end. Else, tell them it is an invalid response. 
            //

            //Console.WriteLine("Write whether you have a dog or a cat?");
            //string anmialAnswer = Console.ReadLine();


            //string animalsName = "";

            //if (anmialAnswer == "cat")
            //{
            //    Console.WriteLine("What is your cats name");
            //    animalsName = Console.ReadLine();
            //}
            //else if (anmialAnswer == "dog")
            //{
            //    Console.WriteLine("What is your dogs name");
            //    animalsName = Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid response");
            //}

            //Console.WriteLine($"thanks for your answer. your {anmialAnswer}'s name is: {animalsName}");

            #endregion

            #region Switch statements

            //Console.WriteLine("What major swedish city do you live closest to (Göteborg, Malmö, Stockholm) ?");
            //string city = Console.ReadLine();


            //switch (city.ToLower())
            //{
            //    case "göteborg":
            //        Console.WriteLine("Your name must be Glen");
            //        break;
            //    case "malmö":
            //        Console.WriteLine("You sound french");
            //        break;
            //    case "stockholm":
            //        Console.WriteLine("You must be fancy");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid response");
            //        break;
            //}

            //Switch with one code block for several cases 

            //Console.WriteLine("Write a number between 1 and 10");
            //int answer = Convert.ToInt32(Console.ReadLine());

            //switch (answer)
            //{
            //    case 0:
            //        {
            //            Console.WriteLine("Invalid response");
            //            break;
            //        }
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //        {
            //            Console.WriteLine("You guessed low");
            //            break;
            //        }
            //    case 5:
            //        {
            //            Console.WriteLine("You guessed in the middle");
            //            break;
            //        }
            //    case 6:
            //    case 7:
            //    case 8:
            //    case 9:
            //    case 10:
            //        {
            //            Console.WriteLine("You Guessed High");
            //            break;
            //        }


            //    default:
            //        {
            //            Console.WriteLine("Number out of range");
            //        }
            //        break;
            //}


            //Switch assignment 

            //Make users guess a random number between 1-10
            //Tell the user If they guess the correct number, tell them if it was either 
            //Low (< 5) or high (> 5). if they guess the wrong answer, tell them if it was 
            //high or low. Tell the user if their number is out of range


            //int correctAnswer = new Random().Next(1, 11);

            //Console.WriteLine("Choose a number between 1 and 10");
            //Console.WriteLine(correctAnswer);
            //int userAnswer = int.Parse(Console.ReadLine());

            //if (userAnswer == correctAnswer)
            //{
            //    switch (correctAnswer)
            //    {

            //        case 1:
            //        case 2:
            //        case 3:
            //        case 4:
            //            {
            //                Console.WriteLine($"Your number: {userAnswer} was correct. You guessed low");
            //                break;
            //            }
            //        case 5:
            //            {
            //                Console.WriteLine($"Your number: {userAnswer} was correct. You guessed in the middle");
            //                break;
            //            }
            //        case 6:
            //        case 7:
            //        case 8:
            //        case 9:
            //        case 10:
            //            {
            //                Console.WriteLine($"Your number: {userAnswer} was correct. You Guessed High");
            //                break;
            //            }

            //    }
            //}

            //else if (userAnswer != correctAnswer)
            //{
            //    switch (userAnswer)
            //    {
            //        case 1:
            //        case 2:
            //        case 3:
            //        case 4:
            //            {
            //                Console.WriteLine($"Your number: {userAnswer} was incorrect. You guessed low");
            //                break;
            //            }
            //        case 5:
            //            {
            //                Console.WriteLine($"Your number: {userAnswer} was incorrect. You guessed in the middle");
            //                break;
            //            }
            //        case 6:
            //        case 7:
            //        case 8:
            //        case 9:
            //        case 10:
            //            {
            //                Console.WriteLine($"Your number: {userAnswer} was incorrect. You Guessed High");
            //                break;
            //            }

            //        default:
            //            {
            //                Console.WriteLine("Number out of range");
            //                break;
            //            }
            //    }

            //}

            #endregion

            #region Intro To loops

            #region For loops

            //for loop (incrementing

            //for (int i = 0; i <= 20; i++)
            //{

            //    Console.WriteLine(i);
            //}

            //decrementing for 
            //for (int i = 20; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}



            //For assignment

            //the "%" modulo operator returns the remainder of two integers

            //log all odd numbers from one - twenty to the console

            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //log all even numbers from 20 - 1 to the console 

            //for (int i = 20; i >= 0; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            #endregion

            #region while loops
            //While loops 


            //int randomNumber = 0;

            ////prints a the value of randomNumber until it returns 3
            //while (randomNumber != 3)
            //{
            //    randomNumber = new Random().Next(1, 4);
            //    Console.WriteLine(randomNumber);
            //}

            //let users guess a number from 1 to 100. Let them continue playing 
            //until they guess the right answer without having the console app end.
            //when they are wrong, tell them whether they guessed too high or too low
            //notify them when they are correct 

            //use int correctAnswer = new Random().Next(1, 101); 


            //int correctAnswer = new Random().Next(1, 101);
            //int guessedAnswer = 0; //initialize the guessed answer before using it

            //while (guessedAnswer != correctAnswer)
            //{
            //    Console.WriteLine("Guess a number from 1 - 100");
            //    guessedAnswer = int.Parse(Console.ReadLine());

            //    if (guessedAnswer < correctAnswer)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine("Wrong! You guessed too Low!");
            //    }

            //    if (guessedAnswer > correctAnswer)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("Wrong! You guessed too high!");
            //    }
            //}
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Finally! You did it!");





            #endregion

            #endregion

            #region Intro To arrays

            //// Creates a new array with 3 spots
            //// you must declare how many spots and array will hold 
            //// when you instantiate it 

            //string[] cities = new string[3];

            //// first spot in array
            //cities[0] = "Göteborg";
            //// second spot
            //cities[1] = "Stockholm";
            //// third spot
            //cities[2] = "Malmö";

            ////  cities[3] = "Växjö"; this will crash. there are not 4 spots.

            //// print out the cities
            //Console.WriteLine(cities[1]);
            //Console.WriteLine(cities[0]);
            //Console.WriteLine(cities[2]);

            ///// another way to create the array

            //string[] cities2 = { "Göteborg", "Stockholm", "Malmö" };
            //int[] years = { 2014, 2017, 1979 };



            //// a list is similar to an array, but you can add and remove items from 
            //// it and it does not have a fixed amount 

            //List<string> cities2 = new List<string>();
            //cities3.Add("Göteborg");
            //cities3.Add("Stockholm");
            //cities3.Add("Malmö");

            ////another way to make a list

            //List<string> cities3 = new List<string>
            //{
            //    "Borås",
            //    "Upsalla",
            //    "Kinna",
            //    "Mölndal"
            //};

            //// print out the cities
            //Console.WriteLine(cities3[1]);
            //Console.WriteLine(cities3[0]);
            //Console.WriteLine(cities3[2]);



            //// loop through a collection
            //for (int i = 0; i < cities3.Count; i++)
            //{
            //    Console.WriteLine($"The city at index {i} is {cities3[i]}");
            //}

            //foreach
            //List<string> cities = new List<string>
            //{
            //    "Los Angeles",
            //    "Chicago",
            //    "New York",
            //    "Philidelphia",
            //    "Houston"
            //};

            //foreach (string city in cities)
            //{
            //    Console.WriteLine($"The city is: {city}");
            //}

            ////Add items to a list from user response

            //List<string> animalsList = new List<string>();

            //Console.WriteLine("Write the name of an animal");
            //string animal1 = Console.ReadLine();
            //animalsList.Add(animal1);

            //Console.WriteLine("Write another animal name");
            //string animal2 = Console.ReadLine();
            //animalsList.Add(animal2);

            //Console.WriteLine("Write the name of one more animal");
            //string animal3 = Console.ReadLine();
            //animalsList.Add(animal3);

            //foreach (string animal in animalsList)
            //{
            //    Console.WriteLine($"You wrote: {animal}");
            //}


            //array and loop assignment 1 

            //create an array with ten numbers, make a loop that adds the maximum amount 
            //of numbers to the array. Make a list of type int. 
            //make a loop that adds the numbers from your array into the list. 
            //make a loop that prints the numbers from your list to the console

            //int[] arrayOfNumbers = new int[10];
            //for (int i = 1; i < arrayOfNumbers.Length; i++)
            //{
            //    arrayOfNumbers[i] = i; 

            //}

            //List<int> listOfNumbers = new List<int>();

            //foreach (int number in arrayOfNumbers)
            //{
            //    listOfNumbers.Add(number);
            //}

            //foreach (int value in listOfNumbers)
            //{
            //    Console.WriteLine(value);
            //}

            #endregion

            #region     in class assignments

            //in class assignment one 

            //Make a game called "FizzBuzz!" 
            // Your program will Count from 1 to 100; every time a number is divisible by 3 
            //make the program write "Fizz", every time a number is divisible by 5 
            //make the program write "Buzz" and every time a number is divisible by 3 and 5, 
            //make the program write "FizzBuzz instead of the number

            //Console.WriteLine("FizzBuzz time, WOOOOO!");

            //for (int i = 1; i <= 100; i++)
            //{
            //    bool fizz = i % 3 == 0;
            //    bool buzz = i % 5 == 0;

            //    if (fizz && buzz)
            //        Console.WriteLine("FizzBuzz");
            //    else if (fizz)
            //        Console.WriteLine("Fizz");
            //    else if (buzz)
            //        Console.WriteLine("Buzz");
            //    else
            //        Console.WriteLine(i);
            //}

            //Assignment two 

            //write a program that lets a user input an integer
            // then writes out the multiplication table for the given int 

            //int y;
            //int x;


            //Console.Write("Input the number (Table to be calculated) : ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\n");
            //for (y = 1; y <= 10; y++)
            //{
            //    Console.Write($"{x} X {y} = {x * y} \n");
            //}

            //Assignment 3 
            //write a program that lets you select how many numbers to put into an 
            //array with a maximum capacity of 25, then prints out to the console 
            //the sum of all of the numbers inside the array 

            //int[] intArray = new int[25];

            //int i;
            //int numberOfElementsInArray;
            //int sum = 0;




            //Console.WriteLine("Input the number of elements to be stored in the array (1-25) :");
            //numberOfElementsInArray = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Input {numberOfElementsInArray} elements in the array :");
            //for (i = 0; i < numberOfElementsInArray; i++)
            //{
            //    Console.Write("element - {0} : ", i);
            //    intArray[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (i = 0; i < numberOfElementsInArray; i++)
            //{
            //    sum += intArray[i];
            //}

            //Console.WriteLine($"The Sum of all elements in the array is : {sum}" );

            //Assignment 4

            //Write a program that counts how many vowels are in a users input 
            // then prints the count to the console 

            //Console.WriteLine("Write a sentence");
            //string textToCheck = Console.ReadLine().ToLower();
            //Console.WriteLine($"Checking string: {textToCheck} for vowels");
            //int count = 0;
            //foreach (char item in textToCheck)
            //{
                

            //    if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
            //    {
            //        count++;
            //    }
                

            //}

            //Console.WriteLine($"There are {count} vowels in your sentence");
            #endregion

        }
    }
}
