using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public class LinkedList
{
    //UC_2
    
    public Node head;
    public void AddNode(int data)
    {
        Node node=new Node(data);
        if(this.head == null)
        {
            head = node;   

        }
        else
        {
            Node temp = head;
            while(temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = node;
        }
        Console.WriteLine("{0} is inserted into linkedlist",data);
    }
    public void Display()
    {
        if(head == null)
        {
            Console.WriteLine("linkedlist is empty");
        }
        else
        {
                Node tempnode = head;  
            while(tempnode != null)
            {
                Console.WriteLine(tempnode.data + " ");
                tempnode = tempnode.Next;
            }
        }
    }


    //UC_1
    public static void Linkedlist()
    {
        LinkedList<int> l2 = new LinkedList<int>();
        l2.AddFirst(56);
        l2.AddLast(30);
        l2.AddLast(70);


        foreach (int i in l2)
        {
            Console.WriteLine(i);

        }
    }
   
}




