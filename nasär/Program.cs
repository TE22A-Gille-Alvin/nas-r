using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

// if (6 >= 3)
// Console.WriteLine("Hello, World!");

// string name = Console.ReadLine();
// string pass = Console.ReadLine();

// if (name == "noname" && pass == "nopass")
// {
//     Console.WriteLine("Welcome!");
// }
// else
// {
//     Console.WriteLine("Wrong username or password");
// }

// for (int i = 0; i < 32; i++)

// {
//     Console.WriteLine("Hello, World!");
// }

// string pass = "";

// while (pass != "nopass")
// {
//     Console.WriteLine("Skriv ditt namn:");
//     pass = Console.ReadLine();
// }


for (int i = 0; i < 5; i++)

{
    string ne = Console.ReadLine();
    int n = 0;
    bool success = int.TryParse(ne, out n);
    if (n > 5)
    {
        Console.WriteLine("Högre än 5!");
    }
}















Console.ReadLine();