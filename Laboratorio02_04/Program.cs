// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Ejercicio 01");
Console.WriteLine("Ingrese un número entero");

try
{
int x = Convert.ToInt32(Console.ReadLine());

if (x == 0)
{
    Console.WriteLine("Resultado: El número es cero");
}
else if (x > 0)
{
    Console.WriteLine("Resultado: El número es positivo");
}
else
{
    Console.WriteLine("Resultado: El número es negativo");
}
}
catch(Exception ex)
{
Console.WriteLine("No ingreso un número" + ex.Message);
}

//ejercicio no. 2:
Console.WriteLine("Ejercicio no. 2");

int dia;

Console.WriteLine("Ingrese un número de la semana (1-7): ");

dia= Convert.ToInt32(Console.ReadLine());

if(dia <=0 || dia > 7) 
 {
    Console.WriteLine("Error: el número debe ser entre 1 y 7");
}
else
{
    switch(dia)
        {
        case 1:
            Console.WriteLine("El día es Lunes");
            break;

        case 2:
            Console.WriteLine("El día es Martes");
            break;

        case 3:
            Console.WriteLine("El día es Miércoles");
            break;

        case 4:
            Console.WriteLine("El día es Jueves");
            break;

        case 5:
            Console.WriteLine("El día es Viernes");
            break;

        case 6:
            Console.WriteLine("El día es Sábado");
            break;

        case 7:
            Console.WriteLine("El día es Domingo");
            break;
    }
}

//tarea lab

Console.WriteLine("Tarea laboratorio");

double dinero;
int Q100, Q50, Q20, Q10, Q5, Q1, C25, C1;
double v100, v50, v20, v10, v5, v1, vc25, vc1;

Console.WriteLine("Ingrese cantidad de dinero");

dinero= Convert.ToDouble(Console.ReadLine());

if (dinero >= 0)
{
    
    Q100 = (int)dinero / 100;
    v100 = Q100 * 100;
    dinero = dinero - v100;

    Q50 = (int)dinero / 50;
    v50 = Q50 * 50;
    dinero = dinero - v50;

    Q20 = (int)dinero / 20;
    v20 = Q20 * 20;
    dinero = dinero - v20;

    Q10 = (int)dinero / 10;
    v10 = Q10 * 10;
    dinero = dinero - v10;

    Q5 = (int)dinero / 5;
    v5 = Q5 * 5;
    dinero = dinero - v5;

    Q1 = (int)dinero / 1;
    v1 = Q1 * 1;
    dinero = dinero - v1;

    dinero = dinero * 100;
    C25 = (int)dinero/ 25;
    vc25 = C25 * 25;
    dinero = dinero - vc25;

        C1 = (int)dinero / 1; 
        vc1 = C1 * 1;
        dinero = dinero - vc1;
    if(dinero > 0.80)
    {
        C1 = C1 + 1;
    }

    Console.WriteLine("Cantidad de dinero Correspondiente:");
    Console.WriteLine(Q100 + " Billetes de Q100");
    Console.WriteLine(Q50 + " Billetes de Q50");
    Console.WriteLine(Q20 + " Billetes de Q20");
    Console.WriteLine(Q10 + " Billetes de Q10");
    Console.WriteLine(Q5 + " Billetes de Q5");
    Console.WriteLine(Q1 + " Billetes de Q1");
    Console.WriteLine(C25 + " Monedas de C 0.25");
    Console.WriteLine(C1 + " Monedas de C 0.01");

}
else
{
    Console.WriteLine("Error: Ingresar una cantidad valida");

}



