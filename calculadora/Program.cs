namespace calculadora
{
    class Program //este es el nombre de la clase Program donde esta el codigo c# 
    {
        public static void Main(string[] args)
        {

            int n1, n2;
            int suma;

            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());

            suma = n1 + n2;
            Console.WriteLine("El resultado de la suma de tus nros es: " + suma);

            //////Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
            int numero;
            int cubo;
            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            cubo = numero * numero * numero;
            Console.WriteLine("El cubo del numero " + numero + " es " + cubo);

            //// Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio 
            ///de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro 
            ///teniendo en cuenta los datos ingresados.


            int kilometrosCiudad1, velocidad;
            int resultado;
            Console.WriteLine("Ingrese cantidad de km entre una ciudad y otra ");
            kilometrosCiudad1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los km por hora que va el vehiculo (promedio) ");
            velocidad = int.Parse(Console.ReadLine());
            resultado = kilometrosCiudad1 / velocidad;
            Console.WriteLine("El tiempo aproximado que te demandará llegar es de: " + resultado + " Horas.");
            /*Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total 
            facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita
            por pantalla el sueldo total a cobrar por el mismo.*/

            // totalFacturado >>> 100%
            //       ???????  >>> 5% 
            //comision = 5 *totalFacturado / 100;

           float totalFacturado, sueldoTotal, comision;

            Console.WriteLine("Ingrese el total facturado por el empleado");
            totalFacturado = float.Parse(Console.ReadLine());
            comision = totalFacturado * 0.05f;//agregué una f ya que lo reconoce como db
            sueldoTotal = 15000 + comision;
            Console.WriteLine("el sueldo del empleado es " + sueldoTotal);


            // Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por
            // pantalla el promedio final.

            float nota1, nota2, nota3, promedio;
            Console.WriteLine("Ingrese la primer nota del alumno");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota del alumno");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercer nota del alumno");
            nota3 = float.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("El promedio del alumno es: "+promedio);
          








        }
    }
}

