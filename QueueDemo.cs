using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class QueueDemo

{
	Node head;
	Node rear;

	public void enqueData(int data)
	{
		Node nodeobj = new Node(data);
		if (head == null)
		{
			rear = nodeobj;	
			head = rear;
		}
		else
		{
			rear.Next = nodeobj;
			rear = rear.Next;
		}
	}

	public void Display()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");


		}
		else
		{
			Node temp = head;
			while (temp != null)
			{
				Console.WriteLine(temp.data + "  ");
				temp=temp.Next;
			}
		}
	}
	
}
