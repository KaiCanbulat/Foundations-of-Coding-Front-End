using System;

int[] scores = {85, 90, 78, 92, 88};

int total = 0;

for (int i = 0; i < scores.Length; i++)
{
total = total + scores[i];
}

Console.WriteLine("Total score: " + total);