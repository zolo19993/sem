

Console.Write("Ввести число N: ");
int N = Convert.ToInt32(Console.ReadLine());
// N = 4, 
int negativeN = N * -1; // -4

while (negativeN <= N) // -3 -2 -1 0 1 2 3
{
    Console.WriteLine(negativeN + " ");
    negativeN++; // negativeN++ (negativeN = negativeN +)
}