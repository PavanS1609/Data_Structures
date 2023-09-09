using System;

public class StackDemo
{
	Node top;
	public StackDemo() 
	{
		top = null;

	}	
	public void PushData(int data)
	{
		Node node = new Node(data);
		node.Next = top;
		top= node;
		Console.WriteLine("{0} is inserted into the stack", data);
	}
	public void Display()
	{
		if(top == null)
		{
			Console.WriteLine("Empty Stack");
		}
		else
		{
			Node temp= top;
			while(temp != null)
			{
				Console.WriteLine(temp.data+"  ");
				temp = temp.Next;
			}
		}
	}
}
