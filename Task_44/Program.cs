// Найти точку пересечения двух прямых заданных уравнением
// y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы

Console.Clear();                            
 
Console.Write("Enter k1:");
int k1 =  int.Parse(Console.ReadLine());
Console.Write("Enter k2:");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Enter b1:");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Enter b2:");
int b2 = int.Parse(Console.ReadLine());
int x = new int();
int y = new int();

void PaymentX(int x)
{
   x = ((b2 - b1) / (k1 - k2));
    Console.WriteLine("Intersection point x: {0}", x);
}
void PaymentY(int y)
{
    y = (k1 *((b2 - b1) / (k1 - k2)) + b1);
    Console.WriteLine("Intersection point y: {0}", y); 
}
PaymentX(x);
PaymentY(y);







