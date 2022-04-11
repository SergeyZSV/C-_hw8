// Заполните спирально массив 4 на 4 числами от 1 до 16.

int rows = 4;
int cols = 4;
int[,] matrix = new int[rows, cols];

FillMatrixSpiral();
PrintMatrix();

void FillMatrixSpiral()
{
    int num = 1;
    int new_row = rows;
    int new_col = cols;

    for (int j = 0; j < cols; j++)
    {
        matrix[0,j] = num;
        num++;
    }
    
    for(int i = 1; i < rows; i++)
    {
        matrix[i, cols - 1] = num;
        num++;
    }
    
    for (int j = cols - 2; j >= 0; j--)
    {
        matrix[rows - 1, j] = num;
        num++;
    }

    for(int i = rows - 2; i > 0; i--)
    {
        matrix[i, 0] = num;
        num++;
    }

    for (int j = 1; j < cols - 1; j++)
    {
        matrix[1, j] = num;
        num++;
    }

    for(int i = 2; i > rows - 3; i--)
    {
        matrix[i, 2] = num;
        num++;
    }
    for (int j = 1; j > 0; j--)
    {
        matrix[2,j] = num;
        num++;
    }
}

void PrintMatrix()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

