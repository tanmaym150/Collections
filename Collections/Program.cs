
using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer() {
                ID = 101,
                Name = "Tanmay",
                Gender = "Male" 

            };
            Customer c2 = new Customer()
            {
                ID = 102,
                Name = "niket",
                Gender = "Male"


            };
            Customer c3 = new Customer()
            {
                ID = 103,
                Name = "damodar",
                Gender = "Male"

            };
            Customer c4 = new Customer()
            {
                ID = 104,
                Name = "Aditi",
                Gender = "Female"

            };
            Customer c5 = new Customer()
            {
                ID = 105,
                Name = "Aishwarya",
                Gender = "Female"

            };
            Console.WriteLine("IN QUEUE..");
            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(c1);
            queueCustomers.Enqueue(c2);
            queueCustomers.Enqueue(c3);
            queueCustomers.Enqueue(c4);
            queueCustomers.Enqueue(c5);
            Console.WriteLine("The total people in the queue are: {0}", queueCustomers.Count);

            Customer c = queueCustomers.Peek();
            Console.WriteLine("The fisrt person in the queue is :{0}",c.Name);
            queueCustomers.Dequeue();//c1 will get deleted

            foreach ( var i in queueCustomers)
            {
                Console.WriteLine("The queue is: ID={0},Name={1},Gender={2}",i.ID,i.Name,i.Gender);

            }
            Console.WriteLine("After dequeue:");
            queueCustomers.Contains(c4);
            Console.WriteLine("{0} is in the queue",c4.Name);
            Console.WriteLine("The total people in the queue are: {0}",queueCustomers.Count);

            Console.WriteLine("IN STACK..");

            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(c1);
            stackCustomers.Push(c2);
            stackCustomers.Push(c3);
            stackCustomers.Push(c4);
            stackCustomers.Push(c5);

            
            Console.WriteLine("The the count of people in the stack is:{0}",stackCustomers.Count);
            stackCustomers.Pop();
            foreach(var v in stackCustomers)
            {
                Console.WriteLine("The stack is :ID={0},Name={1},Gender={2}",v.ID,v.Name,v.Gender);
            }
            Customer s = stackCustomers.Peek();
            Console.WriteLine("{0} is at the top of the stack.",s.Name);
            Console.WriteLine("The the count of people in the stack is:{0}", stackCustomers.Count);






        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }



    }
}
