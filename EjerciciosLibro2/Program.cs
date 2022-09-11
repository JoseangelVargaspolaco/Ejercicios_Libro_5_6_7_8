using System;

 // Este programa visualizar y ejecutar algunos ejercicios propuestos, (capitulo 1,2,3,4) del libro Guia-Total-del-Programador

namespace EjerciciosLibro2
{
    class Program
    {

          // Menu principal donde se ejecutaran las funciones localizadas en el Ejercicio.cs
          
          public static void Main(String[] args)
          {
               Console.Clear(); // Limpiar la pantalla para la ejecucion del programa
               
               int operador = 0;

               Ejercicio eje = new Ejercicio(); // Llamando a las funciones de ejecucion 

               do{

                    Console.Write("\n -----------MENU-----------\n\n 1) Capitulo #5 Ejercicio 4\n 2) Capitulo #5 Ejercicio 5\n 3) Capitulo #6 (Ejercicios 1, 3, 4 y 5)\n 4) Capitulo #7 Ejercicio 1\n 5) Capitulo #7 Ejercicio 2\n 6) Capitulo #7 Ejercicio 5\n 7) Capitulo #8 Ejercicio 3\n 8) Capitulo #8 Ejercicio 5\n 9) Salir\n\n   ---Selecciona una opcion: ");
                    operador = Int16.Parse(Console.ReadLine());
                    Console.Clear();

                    switch(operador)
                    {
                         case 1:
                              Console.Clear();
                              eje.Capitulo_5_ejercicio_4();
                              Console.ReadKey(); 
                              Console.Clear();
                              break;
                         case 2:
                              Console.Clear();
                              eje.Capitulo_5_ejercicio_5();
                              Console.ReadKey();
                              Console.Clear();
                              break;
                         case 3:
                              Console.Clear();
                              eje.Capitulo_6_ejercicio_1_2_3_4_4();
                              Console.ReadKey();
                              Console.Clear();
                              break;
                         case 4:
                              Console.Clear();
                              eje.Capitulo_7_ejercicio_1();
                              Console.ReadKey();
                              Console.Clear();
                              break;
                         case 5: 
                              Console.Clear();
                              eje.Capitulo_7_ejercicio_2();
                              Console.ReadKey();
                              Console.Clear();
                              break;
                         case 6:
                              Console.Clear();
                              eje.Capitulo_7_ejercicio_5();
                              Console.ReadKey();
                              Console.Clear();
                              break;
                         case 7:
                              Console.Clear();
                              eje.Capitulo_8_ejercicio_3();
                              Console.ReadKey();
                              Console.Clear();
                              break;
                         case 8:
                              Console.Clear();
                              eje.Capitulo_8_ejercicio_5();
                              Console.ReadKey();
                              Console.Clear();
                              break;
                         case 9:
                              Console.Clear();
                              break;
                    }

               }while(operador != 9);
          }
    }
}