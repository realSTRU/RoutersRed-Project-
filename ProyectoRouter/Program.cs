using System;
using System.Threading;
using System.Media;
namespace ProyectoRouter
{





    //Bienvenido a nuestro Hermoso codigo Creado por Wilber Galvez y Cesar Reynoso
    
    
    class Program
    {

        //APARTADO No.1 Miembros del menu.
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// Contiene las opciones del menu del inicio de la simulacion guardandolos en un arreglo de strings los cuales 
        /// luego se utilizaran en funciones para fines de estetica
        /// </summary>

        private static string[] OPMENU = new string[]
        {


            "1.Sin participacion del usuario",
            "2.Con participacion del usuario",
            "3.Salir"
          

        };

        /*Estas dos variables se usaran para el manejo de la consola en el menu, con el fin de lograr una funconalidad
         interactiva con el menu*/
        private static int x;
        private static int y;
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        

        //APARTADO No.2 Funcion principal.
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// Main correspondiente a la funcion principal del proyecto
        /// dode se hacen todas las llamadas a funciones externas tanto del class program
        /// como de las otras clases correspondientes a las estruturas de datos utilizadas sin dejar atras que contiene
        /// la parte del inicio de la simulacion y la generacion de los datos de la estructura arbol incluyendo 
        /// la formacion de la estructura que corresponde a la red de arboles que en si es lo que define este proyecto
        /// </summary>
        /// <param Generacion de la primera interfaz = "Titulo, Autores, Inicio de la simulacion" son funcones
        /// propias de la creacion de la pantalla de inicio del programa para dar la bienvenida y el inicio al programa></param>

        static void Main(string[] args)
        {


            if (OperatingSystem.IsWindows())
            {
                SoundPlayer soundPlayer = new SoundPlayer("Rumbling.wav");
                soundPlayer.Load();
                soundPlayer.Play();
                Bar();
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                titulo();
                Autores();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                int Pusuario = 0;
                int Play = 1;

                while (Play == 1)
                {
                   
                    IniciarSimulacion(ref Pusuario, ref Play);
                    soundPlayer.Stop();
                    Console.CursorVisible = true;

                    Console.ForegroundColor = ConsoleColor.Gray;
                    //Console.WriteLine("Como desea hacer la simulacion:\n1.Sin participacion del usuario\n2.Con participacion del usuario");
                    //OP = Convert.ToInt32(Console.ReadLine());
                    int Routers;
                    int Puertos;


                    if (Play == 1)
                    {
                        if (Pusuario == 0)
                        {
                            Routers = GenerarNrouter();
                            Puertos = GenerarNpuerto();
                        }
                        else
                        {
                            Console.WriteLine("Digite el numero de routers de la simulacion");
                            Routers = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite el numero de puertos de la simulacion");
                            Puertos = Convert.ToInt32(Console.ReadLine());

                        }

                        Console.Clear();



                        ///Pruebas sin puertos aleatorios

                        int Respuesta;
                        Console.ForegroundColor = ConsoleColor.Gray;

                        imprimir("Obteniendo numero de routers....");
                        imprimir("Obteniendo numero de puertos....");
                        imprimir("Conectando Terminales....");

                        Console.Clear();
                        Console.WriteLine($"Informacion de la estructura:\n");
                        Console.WriteLine($"No.Routers:{ Routers}");
                        Console.WriteLine($"No.Puertos:{ Puertos}\n");
                        Console.WriteLine($"Desea ver la estructura grafica del arbol de routers antes de empezar la simulacion?:\n1.Si\n2.No\n\nElije una opcion:");
                        Respuesta = Convert.ToInt32(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.White;
                        if (Respuesta == 1)
                        {
                            PrintEstructure(Routers, Puertos);
                            Console.ReadKey();
                        }
                        Console.Clear();

                        PlayProject(Routers, Puertos, Pusuario);

                    }
                    else
                    {
                       
                        SoundPlayer play3 = new SoundPlayer("videojuegos-.wav");
                        play3.PlayLooping();
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.SetCursorPosition(30, 10);
                        Console.CursorVisible = false;
                        imprimir("Bye bye Gracias por utilizar nuestro producto......\n\n");
                        Console.SetCursorPosition(30, 12);
                        Console.WriteLine("Dedicado especialmente a:\n");
                        Console.SetCursorPosition(30, 15);
                        print(@"
                        ░░░░░██╗██╗░░░██╗███╗░░██╗██╗░█████╗░██████╗░  ░██████╗░  
                        ░░░░░██║██║░░░██║████╗░██║██║██╔══██╗██╔══██╗  ██╔════╝░
                        ░░░░░██║██║░░░██║██╔██╗██║██║██║░░██║██████╔╝  ██║░░██╗░
                        ██╗░░██║██║░░░██║██║╚████║██║██║░░██║██╔══██╗  ██║░░╚██╗
                        ╚█████╔╝╚██████╔╝██║░╚███║██║╚█████╔╝██║░░██║  ╚██████╔╝
                        ░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═╝░╚════╝░╚═╝░░╚═╝  ░╚═════╝░ ",5);
                        Console.WriteLine("");

                                            print(@"                                             ▐▓█▀▀▀▀▀▀▀▀▀█▓▌░▄▄▄▄▄░
                                             ▐▓█░░▀░░▀▄░░█▓▌░█▄▄▄█░
                                             ▐▓█░░▄░░▄▀░░█▓▌░█▄▄▄█░
                                             ▐▓█▄▄▄▄▄▄▄▄▄█▓▌░█████░
                                             ░░░░▄▄███▄▄░░░░░█████░                               
                    ",5);


                    }

                    Console.ReadKey();
                    Console.Clear();

                }

            }

            ////PaqueteDato paq = new PaqueteDato('K', 1, 1, 3);

            ////Console.WriteLine(paq);

            //Console.ReadKey();


            //paquete = new PaqueteDato('A', 1, 3, 3);

            //Tree.insertarP(paquete, Raiz);
            ////Tree.tabla[3].Buscar(paquete.destinoRouter);
            ///





        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



        //APARTADO No.3 Inicios del programa y de la simulacion.
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// IniciarSimulacion es parte de la seleccion por parte de los supervisores o los usuarios de este programa
        /// para seleccionar como prefiere hacer la simulacion manual o aleatoria de manera que se decida
        /// si el usuario participara en ul programa o si sera completamente aleatoria
        /// 
        /// La misma sirve para la prueba de cirscunstancias que talvez no sucedan de manera frecuente si la simulacion
        /// fuera de manera aleatoria (errores, rutas conocidas ect..)
        /// </summary>
        /// <param name="Pusuario" argumento de la funcion por medio de referencia para tomarla como variable 
        /// de opcion en los puntos en los cuales se podra dar la participacion del usuario si su valor cambia en la funcion></param>
        static void IniciarSimulacion(ref int Pusuario, ref int Play)
        {
            bool loop = true;
            int counter = 0;
         
            Console.CursorVisible = false;

            ConsoleKeyInfo Tecla;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            imprimir(@" ____  ____  _________  ____  ____  ____  _________  ____  ____  ____  ____  ____  ____  ____  ____  ____  ____ 
||L ||||a ||||       ||||R ||||e ||||d ||||       ||||R ||||e ||||m ||||a ||||s ||||t ||||e ||||r ||||e ||||d ||
||__||||__||||_______||||__||||__||||__||||_______||||__||||__||||__||||__||||__||||__||||__||||__||||__||||__||
|/__\||/__\||/_______\||/__\||/__\||/__\||/_______\||/__\||/__\||/__\||/__\||/__\||/__\||/__\||/__\||/__\||/__\|");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(@"          _____                        _____                            _____          
         /\    \                      |\    \                          /\    \         
        /::\____\                     |:\____\                        /::\    \        
       /:::/    /                     |::|   |                       /::::\    \       
      /:::/   _/___                   |::|   |                      /::::::\    \      
     /:::/   /\    \                  |::|   |                     /:::/\:::\    \     
    /:::/   /::\____\                 |::|   |                    /:::/  \:::\    \    
   /:::/   /:::/    /                 |::|   |                   /:::/    \:::\    \   
  /:::/   /:::/   _/___               |::|___|______            /:::/    / \:::\    \  
 /:::/___/:::/   /\    \              /::::::::\    \          /:::/    /   \:::\    \ 
|:::|   /:::/   /::\____\            /::::::::::\____\        /:::/____/     \:::\____\
|:::|__/:::/   /:::/    /           /:::/~~~~/~~              \:::\    \      \::/    /
 \:::\/:::/   /:::/    /           /:::/    /                  \:::\    \      \/____/ 
  \::::::/   /:::/    /           /:::/    /                    \:::\    \             
   \::::/___/:::/    /           /:::/    /                      \:::\    \            
    \:::\__/:::/    /            \::/    /                        \:::\    \           
     \::::::::/    /              \/____/                          \:::\    \          
      \::::::/    /                                                 \:::\    \         
       \::::/    /                                                   \:::\____\        
        \::/____/                                                     \::/    /        
         ~~                                                            \/____/         ");
            Console.WriteLine("");
            Console.WriteLine("Seleccione como desea hacer la simulacion" + System.Environment.NewLine);

            x = Console.CursorLeft;
            y = Console.CursorTop;

            string RES = MENU(OPMENU, counter);

            while (loop)
            {
                while ((Tecla = Console.ReadKey(true)).Key != ConsoleKey.Enter)
                {
                    switch (Tecla.Key)
                    {

                        case ConsoleKey.DownArrow:
                            if (counter == OPMENU.Length - 1) continue;
                            counter++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (counter == 0) continue;
                            counter--;
                            break;
                        default:
                            break;

                    }

                    Console.CursorLeft = x;
                    Console.CursorTop = y;

                    RES = MENU(OPMENU, counter);



                }

                Console.Clear();

                switch (counter)
                {
                    case 0:
                        loop = false;
                        break;
                    case 1:
                        loop = false;
                        Pusuario = 1;
                        break;
                    case 2:
                        loop = false;
                        Play = 0;
                        break;



                }
            }
        }


        /// <summary>
        /// Parte del inicio del la simulacion lo cual logra la funcionalidad de un menu personalizado 
        /// con la metodologia de solo hacer enter para elegir la opcion deseada en la cual hace que se subraye de un color 
        /// predefinido la opcion en la cual se encentra el usuario moviendose con las flechas de control del teclado
        /// </summary>
        /// <param name="items" variable la cual contiene los strings que corresponden a las opciones></param>
        /// <param name="OP" OP toma como argumento al contador para poder tomar la opcion deseada></param>
        /// <returns></returns>
        static string MENU(string[] items, int OP)
        {
            string Select = string.Empty;

            int Destacado = 0;

            Array.ForEach(items, element =>
            {

                if(Destacado == OP)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(">" + element + "<");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;

                    Select = element;

                }
                else
                {
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.CursorLeft = 0;
                    Console.WriteLine(element);
                }
                Destacado++;

            });


            return Select;
        }


       
        /// <summary>
        /// Titulo es una funcion dada con la fucionalidad de imprimir por pantalla de forma peculiar 
        /// recorriendo la consola el titulo del proyecto
        /// </summary>
        static void titulo()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            string t = "PROYECTO FINAL ESTRUCTURA DE DATOS";

            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.SetCursorPosition(40 + i, j);
                    Console.Write(t[i]);
                    Console.SetCursorPosition(40 + i, j - 1);
                    Console.Write(" ");
                    Thread.Sleep(1);
                }

            }

        }

        /// <summary>
        /// Al igual que la funcion Titulo creada pero con el proposito de imprimir la firma de los autores
        /// </summary>
        static void Autores()
        {

            string t = "By: Cesar Reynoso and Wilber Galvez";

            for (int i = 0; i < t.Length; i++)
            {
                for (int j = 1; j < 15; j++)
                {
                    Console.SetCursorPosition(40 + i, j);
                    if (i < 17 && i > 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(t[i]);
                        
                    }
                    else if(i>21)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write(t[i]);
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(t[i]);
                        
                    }
                    
                    Console.SetCursorPosition(40 + i, j - 1);
                    Console.Write(" ");
                    Thread.Sleep(1);

                }

            }

        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




        //APARTADO No.4 Factor proyecto "Funcion con las estructuras utilizadas para el proyecto ya implementads".
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// Aqui esta la maguia de nuestro proyecto al invocar la funcion PlayProject se ejecutaran nuestras estructuras de datos 
        /// en la manera en que se diseño nuestro programa ideado para utilizar las estructuras las cuales mejoren la eficienecia 
        /// de el programa dentro de los parametros requeridos para cumplir todas las funciones y objetivos de nuestro proyecto
        /// 
        /// en el mismo termina la simulacion tal y como se especifico evidenciando todos los paquetes que llegaron a sus destinos 
        /// y sacandolos haciendo pop de las pilas individuales
        /// </summary>
        /// <param name="Routers">numero de routers generados en el main para la estructura</param>
        /// <param name="Puertos">numero de puertos generados en el main para la estructura</param>
        /// <param name="Pusuario"> 1 si participara el usuario 0 si no participara</param>

        static void PlayProject(int Routers, int Puertos, int Pusuario)
        {
            Arbol Tree = new Arbol(Routers, Puertos);
            PaqueteDato paquete = new PaqueteDato();
            paquete = new PaqueteDato(-1, -1);
            NodoArbol Raiz = Tree.insertar(paquete, null);
            NodoArbol primero = new NodoArbol();
            NodoArbol ultimo = new NodoArbol();
            for (int i = 0; i < Routers; i++)
            {
                for (int j = 0; j < Puertos; j++)
                {
                    if (i == 0)
                    {
                        paquete = new PaqueteDato(i, j);
                        Tree.insertar(paquete, Raiz);
                        primero = Tree.Buscar(0, Raiz);
                        ultimo = Tree.Buscar(Puertos - 1, Raiz);
                    }
                    else if (i % 2 != 0)
                    {

                        if (j == 0)
                        {
                            paquete = new PaqueteDato(i, j);

                            primero = Tree.insertar(paquete, primero);
                            //primero = Tree.Buscar(0, primero);

                            //primero = Tree.Buscar(0, primero);


                            //primero = Tree.insertar(Convert.ToString(i), primero);
                            //Tree.insertar(paquete, primero);
                        }
                        else if (j == Puertos - 1)
                        {
                            paquete = new PaqueteDato(i, j);
                            Tree.insertar(paquete, primero);
                            primero = Tree.Buscar(0, primero);

                        }
                        else
                        {
                            paquete = new PaqueteDato(i, j);
                            Tree.insertar(paquete, primero);

                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            paquete = new PaqueteDato(i, j);
                            ultimo = Tree.insertar(paquete, ultimo);
                            //ultimo = Tree.Buscar(0, ultimo);
                            //Tree.insertar(paquete, ultimo);
                        }
                        else if (j == Puertos - 1)
                        {
                            paquete = new PaqueteDato(i, j);
                            Tree.insertar(paquete, ultimo);
                            /* Al comentar esta linea de codigo podemos formar el arbol en estructura triangulo
                               tal que un hijo al primero de la izquiera y un hijo al ultimo de la derecha */
                            ultimo = Tree.Buscar(0, ultimo);
                        }
                        else
                        {
                            paquete = new PaqueteDato(i, j);
                            Tree.insertar(paquete, ultimo);
                        }
                    }

                }

            }
            int s = 1;
            while (s != 0)
            {
                int Cpaquetes = 3;
                int AuX = 0;
                if(Pusuario == 0)
                {
                    Console.WriteLine("\nGenerando 3 paquetes aleatorios...\n");
                }
                else
                {
                    
                    Console.WriteLine("Digite la cantidad de paquetes que desea enviar a la cola del router raiz:");
                    Cpaquetes = Convert.ToInt32(Console.ReadLine());
                    AuX = Cpaquetes;
                    Console.Clear();
                }
                
                Thread.Sleep(1000);
                Cola cola = new Cola();
                for (int i = 0; i < Cpaquetes; i++)
                {
                    if(Pusuario == 0)
                    {
                        paquete = generarPaquete(Routers, Puertos);
                    }
                    else
                    {
                        int RO;
                        int PU;
                        int PR;
                        char va;
                        Console.WriteLine("Digite el valor del paquete:");
                        va = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Digite el Destino Router del paquete");
                        RO = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el Destino Puerto del paquete:");
                        PU = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite la prioridad del paquete:");
                        PR = Convert.ToInt32(Console.ReadLine());
                       
                        paquete = new PaqueteDato(va, PR, RO, PU);
                    }
                    
                    print($"Enviando a la cola paquete",100);
                    Console.WriteLine(paquete);
                    Thread.Sleep(1000);
                    cola.Push(paquete, paquete.prioridad);
                    if (Pusuario != 0)
                    {

                        AuX--;
                        Console.WriteLine("");
                        Console.WriteLine($"CANTIDAD DE PAQUETES RESTANTES:{AuX}");
                        if(AuX!= 0)
                        {
                            imprimir("PRESIONE CUALQUIER TECLA PARA ENVIAR EL SIGUIENTE PAQUETE.....");
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            Console.Clear();
                            imprimir("NO HAY PAQUETES RESTANTES");
                            imprimir("PRESIONE CUALQUIER TECLA PARA CONTINUAR CON EL PROCESO.....");
                        }
                        
                        
                        Console.ReadKey();
                        Console.Clear();
                    }
                   
                    
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n¡Paquetes generados con exito!\n");
                Console.WriteLine("\nCOLA DEL ROUTER RAIZ\n");
                Thread.Sleep(1000);

                for (int i = 0; i < Cpaquetes; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    imprimir($"\n********PAQUETE NUMERO {i + 1}********\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    imprimir($"{cola.getDato(i)}\n");
                    Thread.Sleep(1000);

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();

                for (int i = 0; i < Cpaquetes; i++)
                {
                    Console.WriteLine($"\nEnviando paquete\n{cola.getDato(i)}\n");
                    if (Tree.tabla[cola.getDato(i).destinoRouter].Esvacia(cola.getDato(i).destinoPuerto))
                    {


                        Console.WriteLine("\nRuta desconocida Recorriendo el arbol...\n");
                        
                        Tree.InsertarP(cola.getDato(i), Raiz);
                      
                    }
                    else
                    {
                        Console.WriteLine("\nRuta conocida, anadiendo directamente a la terminal...\n");
                        Tree.tabla[cola.getDato(i).destinoRouter].insertar(cola.getDato(i));
                        Console.WriteLine("\n¡Añadido con Exito!");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine("Desea Seguir añadiendo paquetes?\n 0.No\n 1.Si");
                s = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            }

            Console.SetCursorPosition(25, 0);
            Console.WriteLine(@"╔══════════════════════════════════════════════════════╗
                         ║ HISTORIAL DE PAQUETES RECIBIDOS EN LA RED DE ROUTERS ║
                         ╚══════════════════════════════════════════════════════╝");


            for (int i = 0; i < Routers; i++)
            {
              

                Console.WriteLine($"\n******ROUTER NUMERO {i}******\n");

                for (int j = 0; j < Puertos; j++)
                {
                    Tree.tabla[i].Buscar(j);
                }
                Thread.Sleep(1000);
            }
        }




        //APARTADO No.5 Funciones Generadoras y funciones auxiliares requeridas para el programa.
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// Funcion aleatoria que genera el numero de routers de la simulacion
        /// </summary>
        /// <returns>El numero de routers</returns>
        static int GenerarNrouter()
        {
            Random numero = new Random();
            int n = 0;
            do
            {
                n = numero.Next(3, 10);

            } while (n > 2 && n % 2 == 0);

            return n;
        }

        /// <summary>
         /// Funcion aleatoria que genera el numero de puertos de la simulacion
         /// </summary>
         /// <returns>El numero de puertos</returns>
        static int GenerarNpuerto()
        {
            Random numero = new Random();
            int n = numero.Next(1, 4);

            switch (n)
            {
                case 1:
                    n = 8;
                    break;
                case 2:
                    n = 16;
                    break;
                case 3:
                    n = 32;
                    break;

                default:
                    break;
            }


            return n;
        }


        /// <summary>
        /// recibe una frase la cual puede ser cualquier string el cual se requiera ser utilizado 
        /// en el programa de forma que se pueda imprimir de manera secuencial cada caracter del string y mediante
        /// la biblioteca Threading poder ajustar esas impresiones en el tiempo que sea necesario
        /// </summary>
        /// <param name="frase">String requerido para imprimir</param>
        static void imprimir(string frase)
        {
            int a = 0;

            while (a != frase.Length)
            {

                Console.Write(frase[a]);
                a++;
                Thread.Sleep(20);

            }

            Console.WriteLine();
        }


        /// <summary>
        /// En simples palabras me genera de forma grafica como se genero la red de arboles de la estrutura
        /// </summary>
        /// <param name="R">Numero de routers ya generados de la simulacion</param>
        /// <param name="P">Numero de puertos ya generados de la simulacion</param>
        static void PrintEstructure(int R, int P)
        {
            


            Arbol1 EstructuraRouter = new Arbol1();
            Random N = new Random();
            NodoArbol1 Raiz = EstructuraRouter.insertar("Raiz", null);
            NodoArbol1 primero = new NodoArbol1();
            NodoArbol1 ultimo = new NodoArbol1();



            for (int i = 0; i < R; i++)
            {


                for (int j = 0; j < P; j++)
                {


                    if (i == 0)
                    {

                        EstructuraRouter.insertar(Convert.ToString(j), Raiz);
                        primero = EstructuraRouter.Buscar("0", Raiz);
                        ultimo = EstructuraRouter.Buscar(Convert.ToString(P - 1), Raiz);

                    }
                    else if (i % 2 != 0)
                    {
                        if (j == 0)
                        {
                            primero = EstructuraRouter.insertar("Router", primero);

                            //primero = Tree.insertar(Convert.ToString(i), primero);

                            EstructuraRouter.insertar(Convert.ToString(j), primero);
                        }
                        else if (j == P - 1)
                        {

                            EstructuraRouter.insertar(Convert.ToString(j), primero);
                            primero = EstructuraRouter.Buscar("0", primero);
                        }
                        else
                        {
                            EstructuraRouter.insertar(Convert.ToString(j), primero);
                        }





                    }
                    else
                    {
                        if (j == 0)
                        {
                            ultimo = EstructuraRouter.insertar("Router", ultimo);



                            EstructuraRouter.insertar(Convert.ToString(j), ultimo);
                        }
                        else if (j == P - 1)
                        {

                            EstructuraRouter.insertar(Convert.ToString(j), ultimo);
                            /* Al comentar esta linea de codigo podemos formar el arbol en estructura triangulo
                               tal que un hijo al primero de la izquiera y un hijo al ultimo de la derecha */
                            ultimo = EstructuraRouter.Buscar("0", ultimo);
                        }
                        else
                        {
                            EstructuraRouter.insertar(Convert.ToString(j), ultimo);
                        }


                    }







                }








            }


            // pruebas con la estructura grafica del router.
            EstructuraRouter.PrintTranversaPreOrd(Raiz, P);
            //Tree.PrintTranversaPostOrd(Raiz);

        }



        /// <summary>
        /// Generar letra devuelve el valor char que tendra el paquete esta funcion sera llamada en generar paquete
        /// </summary>
        /// <returns>char Valor del paquete generado</returns>
        static char generarLetra()
        {
            Random rand = new Random();

            int numero = rand.Next(26);

            char letra = (char)(((int)'A') + numero);
            return letra;
        }

        /// <summary>
        /// Es simple la funcion contiene varias intancias de un objeto random para generar de manera 
        /// aleatoria los miembros de la clase paquete y generar un paquete totalmente aleatorio
        /// </summary>
        /// <param name="routers">numero de puertos para que no genere uno fuera de como se genero la estructura</param>
        /// <param name="puertos">numero de puertos para que no genere uno fuera de como se genero la estructura</param>
        /// <returns>Un paquete aleatorio</returns>
        static PaqueteDato generarPaquete(int routers, int puertos)
        {
            Random R = new Random();
            int Puerto = R.Next(0, puertos - 1);
            int Router = R.Next(0, routers - 1);
            int prioridad = R.Next(0, 10);
            PaqueteDato paquete = new PaqueteDato(generarLetra(), prioridad, Router, Puerto);

            return paquete;

        }
        /// <summary>
        /// Funcionn para imprimir a la velocidad del del segundo parametro de la funcion 
        /// 
        /// </summary>
        /// <param name="frase">Frase requerida </param>
        /// <param name="frames">Velocidad</param>
        static void print(string frase, int frames)
        {
            int a = 0;

            while (a != frase.Length)
            {

                Console.Write(frase[a]);
                a++;
                Thread.Sleep(frames);

            }

            Console.WriteLine();
        }
        /// <summary>
        /// Barra de carga para el inicio de la app
        /// </summary>
        static void Bar()
        {


           
            Console.CursorVisible = false;
            Console.SetCursorPosition(21, 10);
            Console.Write("Cargando programa :");
            string bar = "██";
            
            for(int i = 0; i < 15; i++)
            {
                Console.SetCursorPosition(40+i, 10);
                print(bar, 100);
                Console.SetCursorPosition(40+i, 10);

            }
            Console.Clear();
            Console.SetCursorPosition(21, 10);
            imprimir("Programa completamente cargado presione cualquier tecla para continuar.....");
            Console.ReadKey();

        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    }



}
                                            //⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠛⠛⠛⠋⠉⠈⠉⠉⠉⠉⠛⠻⢿⣿⣿⣿⣿⣿⣿⣿
                                            //⣿⣿⣿⣿⣿⡿⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠛⢿⣿⣿⣿⣿
                                            //⣿⣿⣿⣿⡏⣀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣤⣤⣄⡀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿
                                            //⣿⣿⣿⢏⣴⣿⣷⠀⠀⠀⠀⠀⢾⣿⣿⣿⣿⣿⣿⡆⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿
                                            //⣿⣿⣟⣾⣿⡟⠁⠀⠀⠀⠀⠀⢀⣾⣿⣿⣿⣿⣿⣷⢢⠀⠀⠀⠀⠀⠀⠀⢸⣿
                                            //⣿⣿⣿⣿⣟⠀⡴⠄⠀⠀⠀⠀⠀⠀⠙⠻⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⣿
                                            //⣿⣿⣿⠟⠻⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠶⢴⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⣿
                                            //⣿⣁⡀⠀⠀⢰⢠⣦⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⣿⣿⣿⣿⣿⡄⠀⣴⣶⣿⡄⣿
                                            //⣿⡋⠀⠀⠀⠎⢸⣿⡆⠀⠀⠀⠀⠀⠀⣴⣿⣿⣿⣿⣿⣿⣿⠗⢘⣿⣟⠛⠿⣼
                                            //⣿⣿⠋⢀⡌⢰⣿⡿⢿⡀⠀⠀⠀⠀⠀⠙⠿⣿⣿⣿⣿⣿⡇⠀⢸⣿⣿⣧⢀⣼
                                            //⣿⣿⣷⢻⠄⠘⠛⠋⠛⠃⠀⠀⠀⠀⠀⢿⣧⠈⠉⠙⠛⠋⠀⠀⠀⣿⣿⣿⣿⣿
                                            //⣿⣿⣧⠀⠈⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠟⠀⠀⠀⠀⢀⢃⠀⠀⢸⣿⣿⣿⣿
                                            //⣿⣿⡿⠀⠴⢗⣠⣤⣴⡶⠶⠖⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡸⠀⣿⣿⣿⣿
                                            //⣿⣿⣿⡀⢠⣾⣿⠏⠀⠠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠛⠉⠀⣿⣿⣿⣿
                                            //⣿⣿⣿⣧⠈⢹⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿
                                            //⣿⣿⣿⣿⡄⠈⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣴⣾⣿⣿⣿⣿⣿
                                            //⣿⣿⣿⣿⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿
                                            //⣿⣿⣿⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                                            //⣿⣿⣿⣿⣿⣦⣄⣀⣀⣀⣀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                                            //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
                                            //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠙⣿⣿⡟⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿
                                            //⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠁⠀⠀⠹⣿⠃⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿
                                            //⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⢐⣿⣿⣿⣿⣿⣿⣿⣿⣿
                                            //⣿⣿⣿⣿⠿⠛⠉⠉⠁⠀⢻⣿⡇⠀⠀⠀⠀⠀⠀⢀⠈⣿⣿⡿⠉⠛⠛⠛⠉⠉
                                            //⣿⡿⠋⠁⠀⠀⢀⣀⣠⡴⣸⣿⣇⡄⠀⠀⠀⠀⢀⡿⠄⠙⠛⠀⣀⣠⣤⣤⠄ 
