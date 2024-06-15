using System;
using System.Drawing;
using Console = Colorful.Console;



Console.WriteLine(@" ██████╗ ██████╗ ███╗   ██╗██████╗  ██████╗  ██████╗ █████╗ ██╗      ██████╗
██╔════╝██╔═══██╗████╗  ██║██╔══██╗██╔═══██╗██╔════╝██╔══██╗██║     ██╔════╝
██║     ██║   ██║██╔██╗ ██║██║  ██║██║   ██║██║     ███████║██║     ██║     
██║     ██║   ██║██║╚██╗██║██║  ██║██║   ██║██║     ██╔══██║██║     ██║     
╚██████╗╚██████╔╝██║ ╚████║██████╔╝╚██████╔╝╚██████╗██║  ██║███████╗╚██████╗
 ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚═════╝  ╚═════╝  ╚═════╝╚═╝  ╚═╝╚══════╝ ╚═════╝", Color.Pink);
Console.WriteLine("                  By Devid Dondorf");
Console.WriteLine("             ");
Console.WriteLine("         The Terminal based Condom Size Calculator!!", Color.LightBlue);


Console.WriteLine("             ");
Console.WriteLine("             ");
Console.WriteLine("             ");
Console.WriteLine("Enter the Requested Values below\nBe advised those are not 100% correct values and may deviate");
Console.WriteLine("             ");
Console.WriteLine("             ");
Console.Write("Enter Penis diameter in Centimeters (CM):  ");



string Value1 = Console.ReadLine();
float result = float.Parse(Value1) * 3.14f;

if (result <= 10)
{
    Console.WriteLine("Your fitting condom size would be:"); Console.Write(">> 47 << ", Color.LightGreen);
    Console.WriteLine("                        ");  
}
else if (result >= 10 && result < 10.5)
{
    Console.WriteLine("Your fitting condom size would be:"); Console.WriteLine(">> 49 << ", Color.LightGreen);
    Console.WriteLine("                        ");
}
else if (result >= 10.6 && result < 12)
{
    Console.WriteLine("Your fitting condom size would be:"); Console.WriteLine(">> 53 << ", Color.LightGreen);
    Console.WriteLine("                        ");
}
else if (result >= 13 && result < 13.5)
{
    Console.WriteLine("Your fitting condom size would be:"); Console.WriteLine(">> 57 << ", Color.LightGreen);
    Console.WriteLine("                        ");
}
else if (result >= 13.6 && result < 14.5)
{
    Console.WriteLine("Your fitting condom size would be:"); Console.WriteLine(">> 60 << ", Color.LightGreen);
    Console.WriteLine("                        ");
}
else if (result >= 14.6 && result < 15.5)
{
    Console.WriteLine("Your fitting condom size would be:"); Console.WriteLine(">> 64 << ", Color.LightGreen);
    Console.WriteLine("                        ");
}
else if (result >= 15.5)
{
    Console.WriteLine("Your fitting condom size would be:"); Console.WriteLine(">> 69 << ", Color.LightGreen);
    Console.WriteLine("                        ");
}

Console.WriteLine("The Condom sizes are not uniform. Different brands may have Sizes in between.");



