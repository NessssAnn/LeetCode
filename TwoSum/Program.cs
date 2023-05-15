int[] x1 = { -2,-1,0,1,2  };
double[] x2 = { -1, -0.5, 0, 0.5, 1 };
int[] x3 = { 0, 1, 2, 3, 4 };
for (int i = 0; i<x1.Length; i++)
{
    double y = -Math.Pow(x1[i], 2) + x2[i]+ Math.Pow(x3[i], 2);
    Console.WriteLine(y);
}