// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Definir altura Como Real;
//Definir base Como Real;
//Definir lado Como Real;
//Definir area Como Real;
//Definir volumen Como Real;
//definir arista Como Real;
//Definir contador Como Real;

double area;
double volumen;
double arista;
double contador = 0;
double altura;
double Base = 10 * 10;
double lado;
do
{
    Console.WriteLine("Si desea salir del proceso, ingrese los dos valores negativos.");
    Console.WriteLine("Ingrese la altura de la pirámide.");
    altura = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el lado de la pirámide.");
    lado = double.Parse(Console.ReadLine());
    if (lado > 0 && altura > 0)
    {
        area = lado * (lado + Math.Sqrt(4 * (altura * altura) + (lado * lado)));
        arista = Math.Sqrt((altura * altura + lado * lado) / 2);
        volumen = ((lado * lado) * altura / 3);
        Console.WriteLine($"Con altura de {altura}cms, base de {Base}cms, y lado de {lado}cms, el area es de {area}, el volumen es de {volumen} y la arista es de {arista}.");
        contador++;
    }
    else
    {
        Console.WriteLine("Los valores ingresados son nulos.");
        break;
    }

} while (altura > 0 || lado > 0);
Console.WriteLine($"Se ingresaron un total de {contador} pirámides.");
