public class Program
{
    //Matrice che contiene i numeri di gioco
    static int[,] matrice = new int[9, 9];

    public static void Main(string[] args)
    {

    }

    public static void Matrice()
    {

    }
    
    static bool IsValidMove(int x, int y, int valore)
    {
        // Controlla se il numero può essere inserito nella posizione specificata
        return IsNumberUniqueInRow(x, valore) &&
               IsNumberUniqueInColumn(y, valore) &&
               IsNumberUniqueInBlock(x - x % 3, y - y % 3, valore);
    }

    static bool IsNumberUniqueInRow(int x, int valore)
    {
        for (int y = 0; y < 9; y++)
        {
            if (matrice[x, y] == valore)
                return false;
        }
        return true;
    }

    static bool IsNumberUniqueInColumn(int y, int valore)
    {
        for (int x = 0; x < 9; x++)
        {
            if (matrice[x, y] == valore)
                return false;
        }
        return true;
    }

    static bool IsNumberUniqueInBlock(int startx, int starty, int valore)
    {
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (matrice[startx + x, starty + y] == valore)
                    return false;
            }
        }
        return true;
    }
    static bool IsSudokuSolved()
    {
        // Verifica se la tavola di Sudoku è risolta
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (matrice[i, j] == 0 || !IsValidMove(i, j, matrice[i, j]))
                    return false;
            }
        }
        return true;
    }
}

