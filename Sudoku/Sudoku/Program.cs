public class Program
{
    //Matrice che contiene i numeri di gioco
    static int[,] matrice = new int[9, 9];

    public static void Main(string[] args)
    {
        
    }

    public static bool Inserisci(int x, int y, int valore)
    {
        if (x < 0 && x > 8 || y < 0 && y > 8)
        {
            Console.WriteLine("Posizione non esistente");
            return false;
        }

        matrice[x, y] = valore;
        return true;
    }
}

