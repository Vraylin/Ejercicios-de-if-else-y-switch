using System;

namespace ejercicios
{
    class ejercicios_if_else_switch
    {
        static void Main()
        {
            //Primer ejercicio: Número positivo, negativo o cero.
            Console.WriteLine("****Número positivo, negativo o cero****");
            Console.WriteLine("Ingresa un numero");
            int num= int.Parse(Console.ReadLine());

            if (num > 0)
                Console.WriteLine("El numero es positivo");
            else if (num < 0)
                Console.WriteLine("El numero es negativo");
            else Console.WriteLine("El numero es cero");
            Console.WriteLine();

            //Segundo ejercicio: Número par o impar.
            Console.WriteLine("****Número par o impar****");
            Console.WriteLine("Ingresa un numero entero");
            int num2 = int.Parse(Console.ReadLine());

            if (num2 % 2 == 0)
                Console.WriteLine("El numero es par");
            else 
                Console.WriteLine("El numero es impar");
            Console.WriteLine();

            //Tercer ejercicio: Mayor de edad.
            Console.WriteLine("****Mayor de edad****");
            Console.WriteLine("Ingresa tu edad");
            int edad= int.Parse(Console.ReadLine());

            if (edad >= 18)
                Console.WriteLine("Eres mayor de edad");
            else
                Console.WriteLine("Eres menor de edad");
            Console.WriteLine();

            //Cuarto ejercicio: Múltiplo de 5.
            Console.WriteLine("****Múltiplo de 5****");
            Console.WriteLine("Ingresa un número:");
            int num3 = int.Parse(Console.ReadLine());

            if (num3 % 5 == 0)
                Console.WriteLine("Es múltiplo de 5");
            else
                Console.WriteLine("No es múltiplo de 5");
            Console.WriteLine();

            //Quinto ejercicio: Descuento por edad.
            Console.WriteLine("****Descuento por la edad****");
            Console.WriteLine("Ingresa tu edad:");
            int edad2 = int.Parse(Console.ReadLine());

            if (edad2 >= 60)
                Console.WriteLine("Haz obtenido el descuento del 50%");
            else
                Console.WriteLine("No haz tennido ningun descuento");
            Console.WriteLine();

            //Sexto ejercicio: Calificación aprobatoria.
            Console.WriteLine("****Calificación aprobatoria****");
            Console.WriteLine("Ingresa tu calificación");
            int calificacion= int.Parse(Console.ReadLine());


            if (calificacion >= 60)
                Console.WriteLine("Haz aprovado");
            else
                Console.WriteLine("Reprobaste");
            Console.WriteLine();

            //Septimo ejercicio: Día de la semana.
            Console.WriteLine("****Dias de la semana****");
            Console.WriteLine("Ingrese un numero del 1 al 7");
            int dias = int.Parse(Console.ReadLine());

            switch (dias)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miércoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sábado"); break;
                case 7: Console.WriteLine("Domingo"); break;
                default: Console.WriteLine("Dia no existente"); break;
            }
            Console.WriteLine();

            //Octavo ejecicio: Número mayor entre dos.
            Console.WriteLine("****Número mayor entre dos****");
            Console.WriteLine("Ingresa el primer número:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número:");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
                Console.WriteLine("El mayor es:" + a);
            else if (b > a)
                Console.WriteLine("El mayor es:" + b);
            else
                Console.WriteLine("Son iguales");
            Console.WriteLine();

            //Noveno ejercicio: Mayor entre tres números.
            Console.WriteLine("****Mayor entre tres números****");
            Console.WriteLine("Ingresa tres números:");
            int x = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            if (x >= e && x >= z)
                Console.WriteLine("El mayor es: " + x);
            else if (e >= x && e >= z)
                Console.WriteLine("El mayor es: " + e);
            else
                Console.WriteLine("El mayor es: " + z);

            Console.WriteLine();

            //Décimo ejercicio: Clasificación de ángulos.
            Console.WriteLine("****Clasificación de ángulos****");
            Console.WriteLine("Ingresa el valor del ángulo en grados:");
            int angulo = int.Parse(Console.ReadLine());

            if (angulo < 90)
                Console.WriteLine("Ángulo agudo");
            else if (angulo == 90)
                Console.WriteLine("Ángulo recto");
            else if (angulo < 180)
                Console.WriteLine("Ángulo obtuso");
            else if (angulo == 180)
                Console.WriteLine("Ángulo llano");
            else
                Console.WriteLine("Ángulo no válido");
            Console.WriteLine();


            //Undecimo ejercicio: Cálculo de impuestos.
            Console.WriteLine("****Calculo de impuesto****");
            Console.WriteLine("Ingresa tu salario:");
            double salario = double.Parse(Console.ReadLine());

            if (salario < 10000)
                Console.WriteLine("Impuesto: 0%");
            else if (salario <= 30000)
                Console.WriteLine("Impuesto: 10%");
            else
                Console.WriteLine("Impuesto: 20%");
            Console.WriteLine();
           
            //Duodecimo ejercicio: Clasificación de números.
            Console.WriteLine("****Clasificación de números****");
            Console.WriteLine("Ingresa tres números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > 0 && n2 > 0 && n3 > 0)
                Console.WriteLine("Todos son positivos");
            else if (n1 < 0 && n2 < 0 && n3 < 0)
                Console.WriteLine("Todos son negativos");
            else if (n1 == 0 || n2 == 0 || n3 == 0)
                Console.WriteLine("Hay al menos un cero");
            else
                Console.WriteLine("Hay combinación de signos");
            Console.WriteLine();
           

            //Decimotercer ejercicio: Verificación de año bisiesto.
            Console.WriteLine("****Verificación de año bisiesto****");
            Console.WriteLine("Ingresa un año:");
            int año = int.Parse(Console.ReadLine());

            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                Console.WriteLine("Es bisiesto");
            else
                Console.WriteLine("No es bisiesto");
            Console.WriteLine();

            //Decimocuarto ejercicio: Conversión de calificaciones.
            Console.WriteLine("****Conversión de calificaciones");
            Console.WriteLine("Ingresa la calificación (Entre 0 y 100)");
            int califi = int.Parse(Console.ReadLine());

            if (califi < 0 || califi > 100)
            {
                Console.WriteLine("Error: La calificación debe estar entre 0 y 100.");
            }
            else
            {
                if (califi >= 90)
                    Console.WriteLine("Calificación: A");
                else if (califi >= 80)
                    Console.WriteLine("Calificación: B");
                else if (califi >= 70)
                    Console.WriteLine("Calificación: C");
                else if (califi >= 60)
                    Console.WriteLine("Calificación: D");
                else
                    Console.WriteLine("Calificación: F");
                Console.WriteLine();
            }

            //Decimoquinto ejercicio: Comparación de tres longitudes.
            Console.WriteLine("****Comparación de tres longitudes****");
            Console.WriteLine("Ingresa tres longitudes:");
            int l1 = int.Parse(Console.ReadLine());
            int l2 = int.Parse(Console.ReadLine());
            int l3 = int.Parse(Console.ReadLine());

            if (l1 + l2 > l3 && l1 + l3 > l2 && l2 + l3 > l1)
                Console.WriteLine("Forman un triángulo");
            else
                Console.WriteLine("No forman un triángulo");
            Console.WriteLine();


            //Decimosexto ejercicio: Calculadora de descuentos.
            Console.WriteLine("****Calculadora de descuentos****");
            Console.WriteLine("Ingresa el precio del producto:");
            double precio = double.Parse(Console.ReadLine());

            if (precio < 50)
                Console.WriteLine("Sin descuento");
            else if (precio <= 100)
                Console.WriteLine("5% de descuento");
            else
                Console.WriteLine("10% de descuento");
            Console.WriteLine();

            //Decimoseptimo ejercicio: Tipo de triángulo.
            Console.WriteLine("****Tipo de triángulo****");
            Console.WriteLine("Ingresa tres lados:");
            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int t3 = int.Parse(Console.ReadLine());

            if (t1 == t2 && t2 == t3)
                Console.WriteLine("Equilátero");
            else if (t1 == t2 || t1 == t3 || t2 == t3)
                Console.WriteLine("Isósceles");
            else
                Console.WriteLine("Escaleno");
            Console.WriteLine();

            //Decimooctavo ejercicio: Evaluación de temperatura.
            Console.WriteLine("****Evaluación de temperatura****");
            Console.WriteLine("Ingresa la temperatura en °C:");
            int temp = int.Parse(Console.ReadLine());

            if (temp < 0)
                Console.WriteLine("Hace mucho frío");
            else if (temp <= 20)
                Console.WriteLine("Clima fresco");
            else if (temp <= 30)
                Console.WriteLine("Clima agradable");
            else
                Console.WriteLine("Hace mucho calor");
            Console.WriteLine();

            //Decimonoveno ejercicio: Conversión de horas a turnos.
            Console.WriteLine("****Conversión de horas a turnos****");
            Console.WriteLine("Ingresa la hora (0-23):");
            int hora = int.Parse(Console.ReadLine());

            if (hora >= 6 && hora <= 11)
                Console.WriteLine("En la mañana");
            else if (hora >= 12 && hora <= 17)
                Console.WriteLine("En la tarde");
            else if (hora >= 18 && hora <= 23)
                Console.WriteLine("En la noche");
            else if (hora >= 0 && hora <= 5)
                Console.WriteLine("En la madrugada");
            else
                Console.WriteLine("No existe tal hora");
            Console.WriteLine();

            //Vigésimo ejercicio: Clasificación de IMC.
            Console.WriteLine("****Clasificación de IMC****");
            Console.WriteLine("Ingresa tu peso en kg:");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa tu altura en metros:");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 18.5)
                Console.WriteLine("Bajo peso");
            else if (imc < 25)
                Console.WriteLine("Peso normal");
            else if (imc < 30)
                Console.WriteLine("Sobrepeso");
            else
                Console.WriteLine("Obesidad");

            //**************************

            Console.WriteLine("Como estas");
        }
    }
}