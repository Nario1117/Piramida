// See https://aka.ms/new-console-template for more information
Console.WriteLine("jak má být piramida velká");

int maxNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Tady je piramida velká " + maxNum + " řádky/ů !!!");
for(int row = 1; row <= maxNum; row++)
{
        string conclution = "";
        string spaces = "";
        for (int spaceCount = 1; spaceCount <= maxNum - row; spaceCount++)
        {
          spaces = spaces + " ";  
        }
        for (int num = 1; num <= row; num++)
        {
            conclution = conclution + " " + num;
        }
    Console.WriteLine(spaces + conclution);  
}
Console.ReadKey();
//done :))))