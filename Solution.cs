using System;

public class Test
{
	public static void Main()
	{
		int cases = Convert.ToInt32(Console.ReadLine());
		for(int c = 0; c < cases; c++){
		    string[] inputs = Console.ReadLine().Split();
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            
            Console.WriteLine((a*4) + b);
		}
	}
}
