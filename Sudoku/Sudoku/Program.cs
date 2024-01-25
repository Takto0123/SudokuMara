using System.Text;

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
    public static void visualizzaMatrice()
    {
        Console.WriteLine("Sudoku:");
        StringBuilder sb = new StringBuilder();
        int i = 0;
        while (i != 9)
        {
            for (int c = 0; c < 9; c++)
            {
                sb.Append(matrice[i, c]).Append(" ");
            }
            sb.Append('\n');
            i++;
        }
        Console.WriteLine(Convert.ToString(sb));
    }
}

