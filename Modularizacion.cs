using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("----MENU PRINCIPAL----");
            Console.WriteLine("1. Calculadora Basica");
            Console.WriteLine("2. Validacion de Contraseña");
            Console.WriteLine("3. Numeros Primos");
            Console.WriteLine("4. Suma de Numeros Pares");
            Console.WriteLine("5. Conversion de Temperatura");
            Console.WriteLine("6. Contador de Vocales");
            Console.WriteLine("7. Calculo de Factorial");
            Console.WriteLine("8. Juego de Adivinanza");
            Console.WriteLine("9. Paso por Referencia");
            Console.WriteLine("10. Tabla de Multiplicar");
            Console.WriteLine("0. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    calculadora();
                    break;
                case 2:
                    validacion();
                    break;
                case 3:
                    numprimos();
                    break;
                case 4:
                    numpares();
                    break;
                case 5:
                    temperatura();
                    break;
                case 6:
                    vocales();
                    break;
                case 7:
                    factorial();
                    break;
                case 8:
                    adivinanza();
                    break;
                case 9:
                    preferencia();
                    break;
                case 10:
                    tablasmulti();
                    break;
            }
            Console.WriteLine();
        } while (opcion != 0);
    }

    static void calculadora()
    {
        double n1, n2;
        int opcionop;

        Console.WriteLine("----Calculadora Basica----");
        Console.WriteLine("Ingresa el Primer Numero:");
        if (!double.TryParse(Console.ReadLine(), out n1))
        {
            Console.WriteLine("Numero Invalido.");
            return;
        }

    
        Console.WriteLine("Ingrese el Segundo Numero:");
        if (!double.TryParse(Console.ReadLine(), out n2)) 
        {
            Console.WriteLine("Numero Invalido.");
            return;

        }

        Console.WriteLine("----Eliga la Operacion----");
        Console.WriteLine("1. Suma ");
        Console.WriteLine("2. Resta ");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division ");
        opcionop = int.Parse(Console.ReadLine());
        Console.WriteLine();
        double resultado = 0;
        switch (opcionop)
        {
            case 1:
                resultado = n1 + n2;
                break;
            case 2:
                resultado = n1 - n2;
                break;
            case 3:
                resultado = n1 * n2;
                break;
            case 4:
                resultado = n1 / n2;
                break;
            default:
                Console.WriteLine("Operacion No Valida");
                return;
        }
        Console.WriteLine($"Resultado: {resultado}");
    }

    static void validacion()
    {
        {
            string contrasenacorrecta = "1234"; 
            string contrasenaingresada;

            Console.WriteLine("----- Validación de Contraseña -----");

            do
            {
                Console.Write("Ingresa la contraseña: ");
                contrasenaingresada = Console.ReadLine();

                if (contrasenaingresada != contrasenacorrecta)
                {
                    Console.WriteLine("Contraseña incorrecta. Intentalo de nuevo.");
                }
            } while (contrasenaingresada != contrasenacorrecta);

            Console.WriteLine("Acceso concedido.");
        }
    }
    
    static void numprimos()
    {
        Console.WriteLine("----- Verificación de Números Primos -----");

        Console.Write("Ingresa un número entero: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (EsPrimo(numero))
            {
                Console.WriteLine($"{numero} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número primo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
        }
    }
    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;

        if (numero <= 3)
            return true;

        if (numero % 2 == 0 || numero % 3 == 0)
            return false;

        for (int i = 5; i * i <= numero; i += 6)
        {
            if (numero % i == 0 || numero % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static void numpares()
    {
        Console.WriteLine("----- Suma de Números Pares -----");

        int sumaPares = 0; 
        int numero;

       
        while (true)
        {
            Console.Write("Ingresa un número entero (0 para terminar): ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero == 0)
                {
                    break; 
                }

                if (numero % 2 == 0)
                {
                    sumaPares += numero; 
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
            }
        }
        Console.WriteLine($"La suma de los números pares ingresados es: {sumaPares}");
    }

    static void temperatura()
    {
        int opcion;
        do
        {
            Console.WriteLine("----- Conversión de Temperatura -----");
            Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
            Console.WriteLine("2. Convertir de Fahrenheit a Celsius");
            Console.WriteLine("0. Salir");
            Console.Write("Selecciona una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        ConvertirCelsiusAFahrenheit();
                        break;
                    case 2:
                        ConvertirFahrenheitACelsius();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debes ingresar un número.");
            }
            Console.WriteLine();
        } while (opcion != 0);
    }

    static void ConvertirCelsiusAFahrenheit()
    {
        Console.Write("Ingresa la temperatura en grados Celsius: ");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C equivale a {fahrenheit}°F.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número.");
        }
    }

    static void ConvertirFahrenheitACelsius()
    {
        Console.Write("Ingresa la temperatura en grados Fahrenheit: ");
        if (double.TryParse(Console.ReadLine(), out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit}°F equivale a {celsius}°C.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número.");
        }
    }

    static void vocales()
    {
        Console.WriteLine("----- Contador de Vocales -----");

        Console.Write("Ingresa una frase: ");
        string frase = Console.ReadLine();

        int cantidadVocales = ContarVocales(frase);

        Console.WriteLine($"La frase contiene {cantidadVocales} vocal(es).");
    }

    static int ContarVocales(string texto)
    {
        int contador = 0;
        texto = texto.ToLower();

        foreach (char c in texto)
        {
            if ("aeiouáéíóú".Contains(c))
            {
                contador++;
            }
        }

        return contador;
    }

    static void factorial()
    {
        Console.WriteLine("----- Cálculo de Factorial -----");

        Console.Write("Ingresa un número entero no negativo: ");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
        {
            
            long factorial = CalcularFactorial(numero);

            
            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número entero no negativo.");
        }
    }

    static long CalcularFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1; 
        }

        long resultado = 1;

        for (int i = 2; i <= n; i++)
        {
            resultado *= i;
        }

        return resultado;
    }

    static void adivinanza()
    {
        Console.WriteLine("----- Juego de Adivinanza -----");

        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101); 

        int intento;
        int intentosRealizados = 0;
        bool adivinado = false;

        Console.WriteLine("He generado un numero entre 1 y 100. ¡Adivina cual es!");

        do
        {
            Console.Write("Ingresa tu intento: ");
            if (int.TryParse(Console.ReadLine(), out intento))
            {
                intentosRealizados++;

                if (intento < numeroAleatorio)
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                }
                else if (intento > numeroAleatorio)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                }
                else
                {
                    adivinado = true;
                    Console.WriteLine($"¡Correcto! Adivinaste el numero en {intentosRealizados} intento(s).");
                }
            }
            else
            {
                Console.WriteLine("Entrada no valida. Debes ingresar un número entero.");
            }
        } while (!adivinado);
    }

    static void preferencia()
    {
        Console.WriteLine("----- Intercambio de Números por Referencia -----");

        Console.Write("Ingresa el primer número: ");
        if (int.TryParse(Console.ReadLine(), out int numero1))
        {
            Console.Write("Ingresa el segundo número: ");
            if (int.TryParse(Console.ReadLine(), out int numero2))
            {
                Console.WriteLine($"Valores originales: Número 1 = {numero1}, Número 2 = {numero2}");

                Intercambiar(ref numero1, ref numero2);

                Console.WriteLine($"Valores intercambiados: Número 1 = {numero1}, Número 2 = {numero2}");
            }
            else
            {
                Console.WriteLine("Entrada no válida para el segundo número.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida para el primer número.");
        }
    }

    
    static void Intercambiar(ref int a, ref int b)
    {
        int temp = a; 
        a = b;        
        b = temp;     
    }

    static void tablasmulti()
    {
        Console.WriteLine("----- Tabla de Multiplicar -----");

        
        Console.Write("Ingresa un número entero: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            
            int[] tabla = GenerarTablaMultiplicar(numero);

            MostrarTablaMultiplicar(numero, tabla);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
        }
    }

    static int[] GenerarTablaMultiplicar(int numero)
    {
        int[] tabla = new int[10]; 
        for (int i = 0; i < 10; i++)
        {
            tabla[i] = numero * (i + 1); 
        }
        return tabla;
    }

    static void MostrarTablaMultiplicar(int numero, int[] tabla)
    {
        Console.WriteLine($"\nTabla de multiplicar del {numero}:\n");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{numero} x {i + 1} = {tabla[i]}");
        }
    }

}
