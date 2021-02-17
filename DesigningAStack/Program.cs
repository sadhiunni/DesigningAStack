using System;

/* Designing a Stack which can do the following actions:
 * Push an item
 * Pop an item
 * Display the items present in the stack
 * Clear the stack
 * Quit
 */

namespace DesigningAStack
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Stack stack = new Stack();

            while (exit == false) 
            {
                Console.WriteLine("----------");
                Console.WriteLine("The Stack");
                Console.WriteLine("----------");
                Console.WriteLine("Choose:\nPush\nPop\nDisplay\nClear\nQuit");
                Console.WriteLine("----------");
                var choice = Console.ReadLine();
                
                switch (choice.ToLower())
                {
                    case "push":
                        Console.Clear();
                        Console.WriteLine("Please enter the value you want to put in the stack");
                        object value = (object)(Console.ReadLine());
                        stack.push(value);
                        break;
                    case "pop":
                        Console.Clear();
                        stack.pop();
                        break;
                    case "display":
                        Console.Clear();
                        Console.WriteLine("The Stack");
                        Console.WriteLine("----------");
                        stack.Displaystack();
                        Console.WriteLine("NOTE :Displaying the elements in the stack- first entered in the bottom of the stack and last in on the top of the stack");
                        break;
                    case "clear":
                        Console.Clear();
                        stack.ClearStack();
                        Console.WriteLine("Stack Cleared");
                        break;
                    case "quit":
                        Console.Clear();
                        Console.WriteLine("Exiting.....");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please make a valid choice");
                        break;
                }
            }
        }
    }
}
