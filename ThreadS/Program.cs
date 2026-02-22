

//int[] numbers = { 3, 17, 42, 8, 99, 55, 23, 61, 7, 84, 36, 91, 14, 47, 78 };
//int mid = numbers.Length / 2;
//int max1 = 0;
//int max2 = 0;

//void FindMaxPart(int[] numbers,int start,int end,ref int max)
//{
//     max = numbers[start];
//	for (int i = start + 1; i < end; i++)
//	{
//		if (numbers[i] > max)
//		{
//			max = numbers[i];
//		}
//	}
//}

//var t1 = new Thread(() => FindMaxPart(numbers, 0, mid, ref max1));

//var t2 = new Thread(() => FindMaxPart(numbers, mid,numbers.Length, ref max2));
//t1.Start();
//t2.Start();
//t1.Join();
//t2.Join();
//Console.WriteLine(max1);
//Console.WriteLine(max2);
//Console.WriteLine(Math.Max(max1,max2));


//int[] numbers = { 3, 17, 42, 8, 99, 55, 23, 61, 7, 84, 36, 91, 14, 47, 78,16,18,23,92,27 };
//int[] n1 = numbers.Take(5).ToArray();
//int[] n2 = numbers.Skip(5).Take(5).ToArray();
//int[] n3 = numbers.Skip(10).Take(5).ToArray();
//int[] n4 = numbers.Skip(15).Take(5).ToArray();
//void DisplayArray(int[] numbers) => numbers.ToList().ForEach(x => Console.WriteLine(x));
//DisplayArray(n1);
//Console.WriteLine();
//DisplayArray(n2);
//Console.WriteLine();
//DisplayArray(n3);
//Console.WriteLine();
//DisplayArray(n4);
//Console.WriteLine("XXX");
//int[] SortPartOfArr(int[] numbers) { int[] sorted = numbers.OrderBy(x => x).ToArray(); return sorted; }

//var t1 = new Thread(() => n1 = SortPartOfArr(n1));
//var t2 = new Thread(() => n2 = SortPartOfArr(n2));
//var t3 = new Thread(() => n3 = SortPartOfArr(n3));
//var t4 = new Thread(() => n4 = SortPartOfArr(n4));
//t1.Start();
//t2.Start();
//t3.Start();
//t4.Start();
//t1.Join();
//t2.Join();
//t3.Join();
//t4.Join();

//DisplayArray(n1);
//Console.WriteLine();
//DisplayArray(n2);
//Console.WriteLine();
//DisplayArray(n3);
//Console.WriteLine();
//DisplayArray(n4);
void Waiting()
{
	for (int i = 0; i < 10; i++)
	{
        Console.WriteLine($"Timee {i}");
		Thread.Sleep(1000);
	}
}
void Shortchange()
{
	int i = 0;
	while (true)
	{
        Console.WriteLine(i);
		i++;
        Thread.Sleep(1);
    }
}
var t1 = new Thread(Waiting) ;
var t2 = new Thread( Shortchange);
t1.Start();
t2.Start();
t1.Join();
t2.Join();
