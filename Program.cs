using System.Reflection;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main(string[] args)
    {
    Inicio:
        string selec;
        Console.WriteLine("Escribe tu primer nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Escribe tu primer apellido: ");
        string nombre1 = Console.ReadLine();
        Console.WriteLine(" el nombre de usuario es " + nombre + ("") + nombre1);
        Console.WriteLine("Nombre del creador: Marvin Alexander Rodríguez Hernández, Carnet 1077822");
        Console.WriteLine("Proyecto final");
        Console.WriteLine("Para la funcion de ventilacion presionar el numero 1");
        Console.WriteLine("Para la funcion de calefaccion presionar el numero 2");
        Console.WriteLine("Para la funcion de iluminacion presionar el numero 3");
        Console.WriteLine("Para la funcion de iluminacion presionar el numero 4");
        double ventilacion;
        int horasinicio;
        int horasfinal;
        double ventilacion1;
        pruebaVector pv = new pruebaVector();
        selec = Console.ReadLine();
        {
            switch (selec)
            {
                case "1":
                inicio1:
                    Console.WriteLine("Ingrese la hora de inicio de la ventilacion entre 0 a 12 horas, esta debe ser menor a la final");
                    try
                    {
                        horasinicio = int.Parse(Console.ReadLine());
                        if (horasinicio > 12)
                        {
                            Console.WriteLine("La hora no es valida");
                            goto inicio1;
                        }
                        else if (horasinicio < 0)
                        {
                            Console.WriteLine("La hora no es valida");
                            goto inicio1;
                        }
                        else
                        {
                            Console.WriteLine("la hora ingresada es valida");

                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("dato invalido");
                        goto inicio1;
                    }

                inicio2:
                    Console.WriteLine("Ingrese la hora final de la ventilacion entre 0 a 12 horas ");
                    horasfinal = int.Parse(Console.ReadLine());
                    try
                    {
                        if (horasfinal < horasinicio)
                        {
                            Console.WriteLine("La hora no es valida");
                            goto inicio2;
                        }
                        else if (horasinicio > 12)
                        {
                            Console.WriteLine("La hora no es valida");
                            goto inicio2;
                        }
                        else if (horasinicio < 0)
                        {
                            Console.WriteLine("La hora no es valida");
                            goto inicio2;
                        }
                        else
                        {
                            Console.WriteLine("la hora ingresada es valida");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("dato invalido");
                        goto inicio2;
                    }
                inicio3:
                    Console.WriteLine("ingrese el nivel de humedad menor al 70%");
                    ventilacion = double.Parse(Console.ReadLine());
                    try
                    {
                        if (ventilacion > 70)
                        {
                            Console.WriteLine("El valor dado es incorrecto");
                            goto inicio3;
                        }
                        else
                        {
                            Console.WriteLine("El valor dado es valido");
                        }
                        Console.WriteLine("El valor de la ventilacion es de: " + ventilacion + "%");
                        Console.WriteLine("La hora inicial es: " + horasinicio);
                        Console.WriteLine("La hora final es: " + horasfinal);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("dato invalido");
                        goto inicio3;
                    }
                inicio4:
                    Console.WriteLine("Ingrese el nivel de humedad menor al 70% entre las 12 a 24 horas");
                    ventilacion1 = double.Parse(Console.ReadLine());
                    try
                    {
                        if (ventilacion1 > 70)
                        {
                            Console.WriteLine("El valor dado es incorrecto");
                            goto inicio4;
                        }
                        else
                        {
                            Console.WriteLine("El valor dado es valido");
                        }
                        Console.WriteLine("El valor de la ventilacion es de " + ventilacion1 + "% en la noche");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("dato invalido");
                        goto inicio4;
                    }
                    Console.WriteLine(" el nombre de usuario es " + nombre + ("") + nombre1);
                    break;
                case "2":
                    Console.WriteLine("Calefaccion");
                    pv.Cargar1();
                    pv.Imprimir1();
                    Console.WriteLine(" el nombre de usuario es " + nombre + ("") + nombre1);
                    break;
                case "3":
                    Console.WriteLine("SEGUNDO EJEMPLO VECTORES CON FUNCIONES!");
                    pv.Cargar();
                    pv.Imprimir();
                    Console.WriteLine(" el nombre de usuario es " + nombre + ("") + nombre1);
                    break;
                case "4":
                    Console.WriteLine(" el nombre de usuario es " + nombre + ("") + nombre1);
                    Console.WriteLine("Cerrando el programa");
                    break;

            }
            Console.ReadKey();
        }

    }
}

class pruebaVector
{
    private bool[] cuartos;
    public void Cargar()
    {
        cuartos = new bool[4];
        for (int f = 0; f < 4; f++)
        {
        Cuarto:
            Console.WriteLine("Ingresa 1 para ocupado y 2 para desocupado en el cuarto " + (f + 1));
            string linea;
            linea = Console.ReadLine();
            try
            {
                if (linea == "1")
                {
                    cuartos[f] = true;
                }
                else if (linea == "2")
                {
                    cuartos[f] = false;
                }
                else
                {
                    Console.WriteLine("Numero no valido");
                    goto Cuarto;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("dato invalido");
                goto Cuarto;
            }
        }
    }
    public void Imprimir()
    {
    Imprimir1:
        for (int f = 0; f < 4; f++)
        {
            try
            {
                if (cuartos[f] == true)
                {
                    Console.WriteLine("La luz esta encendida en el cuarto " + (f + 1));
                }
                else
                {
                    Console.WriteLine("La luz esta apagada en el cuarto " + (f + 1));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("dato invalido");
                goto Imprimir1;
            }
        }
    }
    private bool[] cuartos1;
    public void Cargar1()
    {
        cuartos1 = new bool[4];
        for (int f = 0; f < 4; f++)
        {
        Cuarto1:
            Console.WriteLine("Ingresa 1 para encendido y 2 para apagado el radiador en el cuarto " + (f + 1));
            string linea1;
            linea1 = Console.ReadLine();
            try
            {
                if (linea1 == "1")
                {
                    cuartos1[f] = true;
                }
                else if (linea1 == "2")
                {
                    cuartos1[f] = false;
                }
                else
                {
                    Console.WriteLine("Numero no valido");
                    goto Cuarto1;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("dato invalido");
                goto Cuarto1;
            }
        }
    }
    public void Imprimir1()
    {
        for (int f = 0; f < 4; f++)
        {
        Calefaccion1:
            try
            {
                if (cuartos1[f] == true)
                {
                    double calefaccion;
                    Console.WriteLine("ingrese la temperatura esta no debe ser menor a 18 ni mayor a 22 grados centigrados en el cuarto " + (f + 1));
                    calefaccion = double.Parse(Console.ReadLine());
                    if (calefaccion < 18)
                    {
                        Console.WriteLine("El valor dado es incorrecto");
                        goto Calefaccion1;
                    }
                    else if (calefaccion > 22)
                    {
                        Console.WriteLine("El valor dado es incorrecto");
                        goto Calefaccion1;
                    }
                    else
                    {
                        Console.WriteLine("El valor dado es valido");
                    }
                    Console.WriteLine("El valor de la temperatura es de " + calefaccion + " Grados centigrados en el cuarto " + (f + 1));
                }
                else if (cuartos1[f] == false)
                {
                    Console.WriteLine("El calefaccion esta apagada en el cuarto " + (f + 1));
                }
            }
            catch (Exception)
            {

                Console.WriteLine("dato invalido");
                goto Calefaccion1;
            }

        }
    }
}
