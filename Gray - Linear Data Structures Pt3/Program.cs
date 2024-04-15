using System;
using System.Collections.Generic;

public class SequenceGenerator
{
    private Queue<int> queue;

    public SequenceGenerator()
    {
        queue = new Queue<int>();
    }

    public void ConstructSequence(int start, int seqLength)
    {
        queue.Enqueue(start);
        Console.Write(start);
        for (int i = 0; i < seqLength - 1; i++)
        {
            int print = 0;
            if (i % 3 == 0 && i != 0) Dequeue();

            if (i % 3 == 0)
            {
                print = queue.Peek() + 1;
                queue.Enqueue(print);
            }
            else if (i % 3 == 1)
            {
                print = queue.Peek() * 2 + 1;
                queue.Enqueue(print);
            }
            else if (i % 3 == 2)
            {
                print = queue.Peek() + 2;
                queue.Enqueue(print);
            }
            Console.Write(", " + print);
        }
    }

    private void Dequeue()
    {
        queue.Dequeue();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int start = 0;
        bool isValidInput = false;

        while (!isValidInput)
        {
            Console.WriteLine("Enter the starting number: ");

            if (int.TryParse(Console.ReadLine(), out start))
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        SequenceGenerator sequenceGenerator = new SequenceGenerator();
        sequenceGenerator.ConstructSequence(start, 50);
    }
}
