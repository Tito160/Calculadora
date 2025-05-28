using System;

class Calculadora
{
    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA DE CONSOLA ===");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz Cuadrada");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción (1-7): ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Sumar();
                    break;
                case "2":
                     ();
                    break;
                case "3":
                    Multiplicar();
                    break;
                case "4":
                    Dividir();
                    break;
                case "5":
                    Potencia();
                    break;
                case "6":
                    RaizCuadrada();
                    break;
                case "7":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Presione una tecla para intentar de nuevo.");
                    Console.ReadKey();
                    break;
            }
        }

        Console.WriteLine("Gracias por usar la calculadora. ¡Hasta la próxima!");
    }

    static double LeerNumero(string mensaje)
    {
        double numero;
        while (true)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out numero))
                return numero;
            Console.WriteLine("Entrada inválida. Ingrese un número válido.");
        }
    }

    static void Sumar()
    {
        double a = LeerNumero("Ingrese el primer número: ");
        double b = LeerNumero("Ingrese el segundo número: ");
        Console.WriteLine($"Resultado: {a} + {b} = {a + b}");
        Esperar();
    }

    static void Restar()
    {
        double a = LeerNumero("Ingrese el primer número: ");
        double b = LeerNumero("Ingrese el segundo número: ");
        Console.WriteLine($"Resultado: {a} - {b} = {a - b}");
        Esperar();
    }

    static void Multiplicar()
    {
        double a = LeerNumero("Ingrese el primer número: ");
        double b = LeerNumero("Ingrese el segundo número: ");
        Console.WriteLine($"Resultado: {a} * {b} = {a * b}");
        Esperar();
    }

    static void Dividir()
    {
        double a = LeerNumero("Ingrese el numerador: ");
        double b;
        do
        {
            b = LeerNumero("Ingrese el denominador (≠ 0): ");
            if (b == 0)
                Console.WriteLine("No se puede dividir por cero.");
        } while (b == 0);
        Console.WriteLine($"Resultado: {a} / {b} = {a / b}");
        Esperar();
    }

    static void Potencia()
    {
        double baseNum = LeerNumero("Ingrese la base: ");
        double exponente = LeerNumero("Ingrese el exponente: ");
        Console.WriteLine($"Resultado: {baseNum}^{exponente} = {Math.Pow(baseNum, exponente)}");
        Esperar();
    }

    static void RaizCuadrada()
    {
        double numero;
        do
        {
            numero = LeerNumero("Ingrese un número (≥ 0): ");
            if (numero < 0)
                Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
        } while (numero < 0);
        Console.WriteLine($"Resultado: √{numero} = {Math.Sqrt(numero)}");
        Esperar();
    }

    static void Esperar()
    {
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}
