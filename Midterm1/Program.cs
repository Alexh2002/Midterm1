using System;
using System.Collections.Generic;

namespace Midterm1
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant myRestaurant = new Restaurant();

            myRestaurant.ClientArrived("Client 1");
            myRestaurant.ClientArrived("Client 2");
            myRestaurant.ClientArrived("Client 3");
            myRestaurant.ClientArrived("Client 4");
            myRestaurant.ClientArrived("Client 5");

            myRestaurant.HowManyClientsAreWaiting();
            myRestaurant.ClientsCanBeSeated();
            myRestaurant.HowManyClientsAreWaiting();

            myRestaurant.ClientLeaves();
            myRestaurant.PorterCleansDishes();

            myRestaurant.HowManyDirtyDishesDoIHave();

        }
    }
}


public class Restaurant
{
    Queue<string> myQueue = new Queue<string>();
    Stack<string> dirtyDishesStack = new Stack<string>();
    Stack<string> cleanDishesStack = new Stack<string>();

    public void ClientArrived(string theClient)
    {
        myQueue.Enqueue(theClient);
    }

    public void HowManyClientsAreWaiting()
    {
        Console.WriteLine("We have " + myQueue.Count + " waiting");
    }

    public void ClientsCanBeSeated()
    {
        string theClient = myQueue.Dequeue();
        Console.WriteLine("Client: " + theClient + " has been seated");
    }

    public void ClientLeaves()
    {
        dirtyDishesStack.Push("Dish 1");

        Console.WriteLine("Cliet paid and went home");
    }

    public void PorterCleansDishes()
    {
        string theDish = dirtyDishesStack.Pop();
        cleanDishesStack.Push(theDish);

        Console.WriteLine("Porter has cleaned a dish");
    }

    public void HowManyDirtyDishesDoIHave()
    {
        Console.WriteLine("The restaurant has " + dirtyDishesStack.Count + " dirty dishes");
    }
}
