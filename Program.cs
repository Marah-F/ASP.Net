int productCount = 1;
Console.WriteLine($"Enter Product {productCount} Price: ");
int price = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Enter Product {productCount} quantitiy: ");
int quantity = Convert.ToInt32(Console.ReadLine());

int total = price * quantity;
Console.WriteLine($"Total Price of product {productCount} = " + total);

int allTotal = total;

Console.WriteLine("If you want to enter new product enter 1, if want to stop enter 0");
int num = Convert.ToInt32(Console.ReadLine());

while (num == 1)
{
    productCount++;
    Console.WriteLine($"Enter Product {productCount} Price: ");
    price = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Enter Product {productCount} quantitiy: ");
    quantity = Convert.ToInt32(Console.ReadLine());

    total = price * quantity;
    Console.WriteLine($"Total Price of product {productCount} = " + total);

    allTotal += total;

    Console.WriteLine("If you want to enter new product enter 1, if want to stop enter 0");
    num = Convert.ToInt32(Console.ReadLine());


}
Console.WriteLine("All total = " + allTotal);