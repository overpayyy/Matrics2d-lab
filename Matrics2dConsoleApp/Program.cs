using Matrics2dLib;

class Program
{
    static void Main()
    {
        // Tworzenie macierzy
        var m1 = new Matrix2d(1, 3, 7, 2);
        var m2 = new Matrix2d(4, 1, 9, 12);

        Console.WriteLine("Macierz 1:");
        Console.WriteLine(m1);

        Console.WriteLine("\nMacierz 2:");
        Console.WriteLine(m2);

        // Dodawanie macierzy
        var sum = m1 + m2;
        Console.WriteLine("\nDodawanie macierzy (m1 + m2):");
        Console.WriteLine(sum);

        // Odejmowanie macierzy
        var difference = m1 - m2;
        Console.WriteLine("\nOdejmowanie macierzy (m1 - m2):");
        Console.WriteLine(difference);

        // Mnożenie macierzy
        var product = m1 * m2;
        Console.WriteLine("\nMnożenie macierzy (m1 * m2):");
        Console.WriteLine(product);

        // Mnożenie macierzy przez skalar
        var scalarProduct1 = 2 * m1;
        Console.WriteLine("\nMnożenie macierzy przez skalar (2 * m1):");
        Console.WriteLine(scalarProduct1);

        var scalarProduct2 = 2 * m2;
        Console.WriteLine("\nMnożenie macierzy przez skalar (2 * m2):");
        Console.WriteLine(scalarProduct2);

        // Transpozycja macierzy
        var transposed1 = Matrix2d.Transpose(m1);
        Console.WriteLine("\nTranspozycja macierzy m1:");
        Console.WriteLine(transposed1);

        var transposed2 = Matrix2d.Transpose(m2);
        Console.WriteLine("\nTranspozycja macierzy m2:");
        Console.WriteLine(transposed2);

        // Wyznacznik macierzy
        var determinant1 = m1.Det();
        Console.WriteLine("\nWyznacznik macierzy m1:");
        Console.WriteLine(determinant1);

        // Wyznacznik macierzy
        var determinant2 = m2.Det();
        Console.WriteLine("\nWyznacznik macierzy m2:");
        Console.WriteLine(determinant2);

        // Parsowanie macierzy z ciągu znaków
        var input = "[9, 8], [7, 6]";
        var parsedMatrix = Matrix2d.Parse(input);
        Console.WriteLine("\nParsowanie macierzy z ciągu znaków:");
        Console.WriteLine($"Input: {input}");
        Console.WriteLine(parsedMatrix);

        // Konwersja macierzy na tablicę int[,]
        int[,] array1 = (int[,])m1;
        Console.WriteLine("\nKonwersja macierzy m1 na tablicę int[,]:");
        Console.WriteLine($"[{array1[0, 0]}, {array1[0, 1]}]");
        Console.WriteLine($"[{array1[1, 0]}, {array1[1, 1]}]");

        int[,] array2 = (int[,])m2;
        Console.WriteLine("\nKonwersja macierzy m2 na tablicę int[,]:");
        Console.WriteLine($"[{array2[0, 0]}, {array2[0, 1]}]");
        Console.WriteLine($"[{array2[1, 0]}, {array2[1, 1]}]");

    }
}
