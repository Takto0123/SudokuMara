using System.Text;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    //Matrice che contiene i numeri di gioco
    static int[,] matrice = new int[9, 9];
    public static void Main(string[] args)
    {
        bool ok = false;
        do
        {
            visualizzaMatrice();
            Console.WriteLine("Inserisci posizione x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci posizione y");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci valore");
            int valore = Convert.ToInt32(Console.ReadLine());
            Inserisci(x, y, valore);
            //IsValidMove(x, y, valore);
            //IsSudokuSolved();
            if (IsNumberUniqueInColumn() == true && IsNumberUniqueInRow() == true)
            {
                ok = true;
                Console.WriteLine("hai vinto");
            }else { Console.WriteLine("non hai ancora vinto"); }
        }
        while(ok == false);
        
        


        
        
        




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
    
    //static bool IsValidMove(int x, int y, int valore)
    //{
    //    // Controlla se il numero può essere inserito nella posizione specificata
    //    return IsNumberUniqueInRow(x, valore) &&
    //           IsNumberUniqueInColumn(y, valore) &&
    //           IsNumberUniqueInBlock(x - x % 3, y - y % 3, valore);
    //}

    static bool IsNumberUniqueInRow()
    {
        int punt = 0;
        int[] ints = new int[9];
        for (int y = 0; y < 9; y++)
        {
            for(int x= 0; x < 9; x++)
            {
                for(int i = 0; i < 9; i++)
                {
                    ints[i] = matrice[x, y];
                }
                int cont = 0;
                for (int i = 0; i < ints.Count(); i++)
                {
                    int pos = ints[i];
                    for (int z = 0; z < ints.Count(); z++)
                    {
                        if (pos == ints[z])
                        {
                            cont++;
                        }
                    }
                }
                if (cont == 1) { punt++; }
            }              
        }
        if (punt == 9)
            return true;
        return false;
    }

    static bool IsNumberUniqueInColumn()
    //{
    //    for (int x = 0; x < 9; x++)
    //    {
    //        if (matrice[x, y] == valore)
    //            return false;
    //    }
    //    return true;
    //}
    {
        int punt = 0;
        int[] ints = new int[9];
        for (int y = 0; y < 9; y++)
        {
            for (int x = 0; x < 9; x++)
            {
                for (int i = 0; i < 9; i++)
                {
                    ints[i] = matrice[y, x];
                }
                int cont = 0;
                for (int i = 0; i < ints.Count(); i++)
                {
                    int pos = ints[i];
                    for (int z = 0; z < ints.Count(); z++)
                    {
                        if (pos == ints[z])
                        {
                            cont++;
                        }
                    }
                }
                if (cont == 1) { punt++; }
            }
        }
        if (punt == 9)
            return true;
        return false;
    }

    //static bool IsNumberUniqueInBlock(int startx, int starty, int valore)
    //{
    //    for (int x = 0; x < 3; x++)
    //    {
    //        for (int y = 0; y < 3; y++)
    //        {
    //            if (matrice[startx + x, starty + y] == valore)
    //                return false;
    //        }
    //    }
    //    return true;
    //}
    static bool IsSudokuSolved()
    {
        // Verifica se la tavola di Sudoku è risolta
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                //if (matrice[i, j] == 0 || !IsValidMove(i, j, matrice[i, j]))
                //    return false;

            }
        }
        return true;
    }
}

