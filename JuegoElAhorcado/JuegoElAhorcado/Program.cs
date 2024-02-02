namespace JuegoElahorcado
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Van a jugar uno o dos jugadores?");
            Console.WriteLine("1) Un jugador");
            Console.WriteLine("2) Dos jugadores");
            string opc = Console.ReadLine();
            Console.Clear();

            if(opc == "1")
            {
                string[] palabras = {"vaso", "mochila","caballo","automovil","escoba","arbol","arbusto","cabello","raton","zebra" };
                Random random= new Random();
                int random_num = random.Next(0,10);
                char[] letras = palabras[random_num].ToCharArray();
                int word_length = letras.Length;
                int[] flagletras = new int[word_length];
                int intentos = 6;
                for(int i = 0; i < word_length; i++)
                {
                    flagletras[i]= 0;
                }

                bool game = true;

                do
                {
                    int letras_check = 0;
                    Console.WriteLine("Intentos restantes: " + intentos);
                    for (int h = 0; h < word_length; h++)
                    {
                        if (flagletras[h] == 0)
                        {
                            Console.Write(" _ ");
                        }
                        else
                        {
                            Console.Write(" " + letras[h] + " ");
                            letras_check++;
                        }

                    }
                    if(letras_check == word_length)
                    {
                        game = false;
                        Console.WriteLine("\n\n HAS GANADO EL JUEGO!!!, FELICIDADES");
                    }
                    else
                    {
                        Console.WriteLine("\n\nIngresa una letra: ");
                        char letra = Convert.ToChar(Console.ReadLine());
                        bool flagcheck = false;
                        for(int x = 0; x < word_length; x++)
                        {
                            if(letra== letras[x])
                            {
                                flagletras[x] = 1;
                                flagcheck = true;
                            }
                        }
                        if(flagcheck == false)
                        {
                            intentos  --;
                        }
                        if(intentos == 0)
                        {
                            game = false;
                            Console.WriteLine("\nGAME OVER");
                        }

                    }
                }while(game == true);
            }

            if (opc == "2")
            {
               Console.WriteLine("Jugador 1 Ingresa una palabra sin que te vea el jugador 2");
                string palabra = Console.ReadLine();
                Console.Clear();
                char[] letras = palabra.ToCharArray();
                int word_length = letras.Length;
                int[] flagletras = new int[word_length];
                int intentos = 6;
                for (int i = 0; i < word_length; i++)
                {
                    flagletras[i] = 0;
                }

                bool game = true;

                do
                {
                    int letras_check = 0;
                    Console.WriteLine("Intentos restantes: " + intentos);
                    for (int h = 0; h < word_length; h++)
                    {
                        if (flagletras[h] == 0)
                        {
                            Console.Write(" _ ");
                        }
                        else
                        {
                            Console.Write(" " + letras[h] + " ");
                            letras_check++;
                        }

                    }
                    if (letras_check == word_length)
                    {
                        game = false;
                        Console.WriteLine("\n\n HAS GANADO EL JUEGO jugador 2!!!, FELICIDADES");
                    }
                    else
                    {
                        Console.WriteLine("\n\nIngresa una letra: ");
                        char letra = Convert.ToChar(Console.ReadLine());
                        bool flagcheck = false;
                        for (int x = 0; x < word_length; x++)
                        {
                            if (letra == letras[x])
                            {
                                flagletras[x] = 1;
                                flagcheck = true;
                            }
                        }
                        if (flagcheck == false)
                        {
                            intentos--;
                        }
                        if (intentos == 0)
                        {
                            game = false;
                            Console.WriteLine("\nHas ganado el juego jugador 1 FELICIDADES");
                        }

                    }
                } while (game == true);
            }

        }

       
    
    }

}
