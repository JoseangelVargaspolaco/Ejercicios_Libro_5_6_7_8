using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Data;



// Funciones de ejecucion del programa

namespace EjerciciosLibro2
{
     class Ejercicio
     {
          //Hacer una función que calcule el factoria  de un número.
          public void Capitulo_5_ejercicio_4()
          {
               Console.WriteLine("Digite un numero: ");
               int numero = Int32.Parse(Console.ReadLine());
               int Factorial = 1;
               for (int i = 1; i <= numero; i++)
               {
                    Factorial *= i;
               }
               Console.WriteLine($"Factotial de {numero} es: {Factorial}");

          }

          /* 
            Hacer una función que dado un número
            nos regrese una cadena donde se
            encuentre escrito en palabras.
          */

          public void Capitulo_5_ejercicio_5()
          {
              Console.WriteLine("Digite un numero del 1 al 5");
              int _numero = Convert.ToInt32(Console.ReadLine());

               switch (_numero)
               {
                    default:
                         Console.WriteLine("Opción no valida");
                         break;
                    case 1:
                         Console.WriteLine(" Uno");
                         break;
                    case 2:
                         Console.WriteLine(" Dos");
                         break;
                    case 3:
                         Console.WriteLine(" Tres");
                         break;
                    case 4:
                         Console.WriteLine(" Cuatro");
                         break;
                    case 5:
                         Console.WriteLine(" Cinco");
                         break;
               }
          }



          /* 1. Agregar el cálculo del promedio para el programa con arreglo jagged.

             2. Agregar el cálculo de la menor calificación para el programa con arreglo jagged.

             3. Agregar el cálculo de la mayor calificación para el programa con arreglo jagged.

             4. Modificar el programa de la escuela para que utilice funciones.

             5. Crear un programa que pase un arreglo jagged como parámetro a una función. 

          */

          public void Capitulo_6_ejercicio_1_2_3_4_4()
          {
               // Variables necesarias
               int cantidad = 0; // Cantidad de alumnos
               int salones = 0; // Cantidad de salones
               int n = 0; // Variable de control de ciclo salones
               int m = 0; // Variable de control del ciclo alumnos
               string valor = "";

               // Variables para el promedio
               float suma = 0.0f;
               float promedio = 0.0f;
               float minima = 10.0f; //Variable para la calificación mínima
               float maxima = 0.0f; //Variable para la calificación maxima

               // Pedimos la cantidad de salones
               Console.WriteLine("Dame la cantidad de salones");
               valor = Console.ReadLine();
               salones = Convert.ToInt32(valor);
               // Creamos el arreglo
               float[][] calif = new float[salones][];
               // Pedimos los alumnos por salon
               for (n = 0; n < salones; n++) // Ciclo salones
               {
                    Console.WriteLine($"Dame la cantidad de alumno spara el salon {0}", n);
                    valor = Console.ReadLine();
                    cantidad = Convert.ToInt32(valor);
                    // Instanciamos el arreglo
                    calif[n] = new float[cantidad];
               }

               // Capturamos la información
               for (n = 0; n < salones; n++) // Ciclo salones
               {
                    Console.WriteLine("\nSalon {0}", n);
                    for (m = 0; m < calif[n].GetLength(0); m++) //Ciclo alumnos
                    {
                         Console.Write("Dame la calificación ");
                         valor = Console.ReadLine();
                         calif[n][m] = Convert.ToSingle(valor);

                         suma += calif[n][m];

                         if (calif[n][m] > maxima)

                              maxima = calif[n][m];

                         else if (calif[n][m] < minima)

                              minima = calif[n][m];
                    }

                    promedio = suma / calif[n].GetLength(0);
                    Console.WriteLine($"EL Promedio de Calificaciones es: {promedio}");

               }

               Infomacion(calif, salones, m, maxima, minima);

          }

          // Funcion Informacion
          public static void Infomacion(float[][] calif, int salones, int m, float maxima, float minima)
          {

               Console.WriteLine("—— Información ——");
               for (int n = 0; n < salones; n++) // Ciclo salones
               {
                    Console.WriteLine("\nSalon {0}", n);
                    for (m = 0; m < calif[n].GetLength(0); m++) // Ciclo alumnos
                    {
                         Console.WriteLine("El alumno {0} tiene {1}", m, calif[n][m]);
                    }
                    Console.Write($"\nLa mayor venta es: {maxima}");
                    Console.Write($"\nLa menor venta es: {minima}");
               }
          }

           /*
            Hacer el programa que calcula el
            promedio, calificación máxima y mínima
            de un salón de clases usando el ArrayList.
          */            
          public void Capitulo_7_ejercicio_1()
          {

               // Nuestro arreglo

               // Vamos a almacenar la sumatoria
               int sumatoria = 0;

               int[] calificaciones = new int[15];
               int v, max = calificaciones[0], min = calificaciones[0];
               for (int i = 0; i < 5; i++)
               {
                    Console.Write("Ingrese las calificaciones: ");
                    v = int.Parse(Console.ReadLine());
                    calificaciones[i] = v;
               }

               // Lo recorremos con un foreach
               foreach (int i in calificaciones)
               {
                    // Ir agregando la calificación a la sumatoria
                    sumatoria += i;
               }
               // El promedio resulta de dividir la sumatoria entre la cantidad de elementos
               int promedio = sumatoria / calificaciones.Length;
               Console.WriteLine("Promedio: " + promedio);
               Console.Write("\n\nLa mayor venta es: " + calificaciones.Max());
               Console.Write("\n\nLa menor venta es: " + calificaciones.Min()+"\n\n");
          }

          /*
            Hacer un programa que funcione como un
            diccionario, con palabra y definición,
            usando el Hashtable.
          */ 

          public void Capitulo_7_ejercicio_2()
          {

               String cadena = String.Empty;
               int dijito = 0;

               cadena = Console.ReadLine();
               dijito = Int32.Parse(Console.ReadLine());

               Console.Clear();

               Dictionary<String, int> datos = new Dictionary<string, int>();
               datos.Add(cadena, dijito);

               foreach (KeyValuePair<String, int> data in datos)
               {
                    Console.Clear();
                    Console.WriteLine("DESCRIPCION\n " + data.Key + "\nNUMERO:" + data.Value);
                    Console.ReadKey();
               }

          }

          /*
            Hacer un programa que funcione como
            una agenda telefónica y que guarde el
            nombre de la persona y su número
            telefónico.
          */ 
          public void Capitulo_7_ejercicio_5()
          {

               String nombre;
               int numero_telefonico;

               nombre = Console.ReadLine();
               numero_telefonico = Int32.Parse(Console.ReadLine());

               Console.Clear();

               Dictionary<String, int> datos = new Dictionary<string, int>();
               datos.Add(nombre, numero_telefonico);

               foreach (KeyValuePair<String, int> data in datos)
               {
                    Console.Clear();
                    Console.WriteLine("Nombre: \n " + data.Key + "\nNombre:" + data.Value);
                    Console.ReadKey();
               }

          }

          /*
            Hacer un programa que muestre la hora
            del día en formato AM/FM seguida del
            año, el día y el mes actual.
          */ 
          public void Capitulo_8_ejercicio_3()
          {
               DateTime hora = DateTime.Now;
               Console.WriteLine("La hora es: " + hora.ToString("h:mm:ss AM/PM"));
               Console.WriteLine(" \n La fecha es: " + hora.ToLongDateString());
          }

          /*
            Hacer un programa que le solicite al
            usuario dos cadenas y luego las muestre
            en orden alfabético.
          */ 
          public void Capitulo_8_ejercicio_5()
          {
               char datos;
               string Cadena = Console.ReadLine();
               string Data = Cadena.ToLower();
               char[] letra = Data.ToCharArray();

               for (int i = 1; i < letra.Length; i++)
               {
                    for (int j = 0; j < letra.Length - 1; j++)
                    {
                         if (letra[j] > letra[j + 1])
                         {
                              datos = letra[j];
                              letra[j] = letra[j + 1];
                              letra[j + 1] = datos;
                         }
                    }
               }
               Console.WriteLine(letra);
               Console.ReadLine();

        }

    }
}