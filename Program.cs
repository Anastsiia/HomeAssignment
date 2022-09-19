using System.Collections;
using System.Collections.Generic;


List<int> t = new List<int>();
t.Add(1);
t.Add(2);
t.Add(3);
t.Add(4);
t.Add(5);

RandomFactory<int> x = new RandomFactory<int>(t);
x.RemoveItem(0);

for (int i = 10; i < 50; i++)
{
    KeyValuePair<int, int> random = x.GetRandom();
    Console.WriteLine("Random Key: {0}, Value: {1}", random.Key, random.Value);
}

Console.ReadLine();