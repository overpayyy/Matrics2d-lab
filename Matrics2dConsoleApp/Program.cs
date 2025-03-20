using Matrics2dLib;
var m = new Matrix2d(1,2,3,4);
Console.WriteLine(m);

int[,] a = { { 1, 2 }, { 3, 4 } };
int[,] b = { { 5, 6 }, { 7, 8 } };

Matrix2d m1 = a + (Matrix2d)b;
