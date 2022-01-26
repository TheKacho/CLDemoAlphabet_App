using System;

Console.WriteLine("Press any key to see the regular alphabet.\n");

Console.ReadKey();

string alphabet = "";
for (char alpha = 'A'; alpha <= 'Z'; alpha++)
{
    alphabet += alpha;
}

Console.WriteLine($"{alphabet} \n");

Console.WriteLine("Press any key to see the alphabet in reverse.\n \n");

Console.ReadKey();


string reverse = "";
for (char alphaR = 'Z'; alphaR >= 'A'; alphaR--)
{
    reverse += alphaR;
}

Console.WriteLine($"{reverse} \n");
Console.WriteLine("Press any key to see a skipped alphabet.\n \n");

Console.ReadKey();

string skipped = "";

for (char alphaS = 'A'; alphaS <= 'Z'; alphaS++, alphaS++)
{
    skipped += alphaS;
}

Console.WriteLine($"{skipped} \n");