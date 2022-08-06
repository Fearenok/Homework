int a = 7;
int b = 3;
int c = 2;

int max = a;

if (b > a ) max = b;
if (c > max ) max = c;

Console.WriteLine("max = ");
Console.WriteLine(max);