class Program
{
    private static void Main(string[] args)
    {
        float a,b;
        Console.WriteLine("Moi nhap he so a va b: ");
        a=float.Parse(Console.ReadLine());
        b=float.Parse(Console.ReadLine());
        if(a!=0)
        {
            Console.WriteLine("Phuong trinh co 1 nghiem duy nhat la: " + (-b)/a);
        }
        else
        {
            if(b==0)
            {
                Console.WriteLine("Phuong trinh co vo so nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
    }
}