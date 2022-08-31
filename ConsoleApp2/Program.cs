int x = 9, z = 6; double y = 8;  

Console.WriteLine(x-- == y);      	    //False
Console.WriteLine(x == (int)y);         //True
Console.WriteLine("{0:F1}", 0, 123);    //0.0
Console.WriteLine(z / y);               //0.75
Console.WriteLine(x -= 10);             //-2
Console.WriteLine(x-- == y & true);     //False
Console.WriteLine(!(z == 6) | false);   //False
Console.WriteLine((x *= -2) == z);      //True

int auswahl; 

Console.WriteLine("(1) Umrechnung con celsius nach kelvin");
Console.WriteLine("(2) Umrechnung von Celsius nach Fahrenheit");
Console.WriteLine("(3) Umrechnung von Kelvin nach Celsius");
Console.WriteLine("(4) Umrechnung von Kelvin nach Fahrenheit"); 

auswahl = Convert.ToInt16(Console.ReadLine());
switch (auswahl)
{    case 1:        Console.Write("Gib die zahl in Celsius an:");        double celsius = Convert.ToDouble(Console.ReadLine());        double kelvin = (celsius + 273.15);        Console.WriteLine("{0} C° sind {1} Klevin", celsius, kelvin);        break; 

   case 2:        Console.Write("Gib die Zahl in Celsius an:");        double celsius1 = Convert.ToDouble(Console.ReadLine());        double fahrenheit = ((celsius1 * 9 / 5) + 32);        Console.WriteLine("{0} C° sind {1}° Fahrenheit", celsius1, fahrenheit);        break;    
 case 3:        Console.Write("Gib die Zahl in Kelvin an:");        double klevin1 = Convert.ToDouble(Console.ReadLine());        double celsius2 = (klevin1 - 273.15);        Console.WriteLine("{0} Klevin sind {1} C°", klevin1, celsius2);        break;    
 case 4:        Console.Write("Gib die Zahl in Celsius an:");        double kelvin2 = Convert.ToDouble(Console.ReadLine());        double fahrenheit1 = ((kelvin2 - 273.15) * 9 / 5 + 32);        Console.WriteLine("{0} kelvin sind {1}° Fahrenheit", kelvin2, fahrenheit1);     break;    
 default:        Console.WriteLine("Da ist etwas schief gelaufen:/");        break;
}
