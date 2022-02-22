// Написать программу масштабирования фигуры

Console.Clear();

Console.Write("Enter the coordinates of the figure separated by a space (For example, (2,1) (0,0) (2,3) (1,2)): ");
string[] coordintes = Console.ReadLine().Split(" ");
Console.Write("Enter Scale Factor: ");
double m = double.Parse(Console.ReadLine());
for (int i = 0; i < coordintes.Length; i++) Console.Write(coordintes[i] + " ");
Console.WriteLine();
double[] StrToDoubleCoordinate = new double[coordintes.Length * 2];
for (int i = 0, j = 0; i < coordintes.Length; i++, j += 2)
{
    string[] temp = coordintes[i].Split('(', ',', ')');
    StrToDoubleCoordinate[j] = Math.Round((double.Parse(temp[1])) * m , 2);
    StrToDoubleCoordinate[j + 1] = Math.Round((double.Parse(temp[2])) * m, 2);
}
Console.Write("The resulting figure coordinates: ");
for (int i = 0, j = 0; i < coordintes.Length; i++, j += 2) 
Console.Write($"({StrToDoubleCoordinate[j]};{StrToDoubleCoordinate[j + 1]}) ");











