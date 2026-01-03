// Console.WriteLine("Makan apaa Bang ? ");
// string input = Console.ReadLine();
// Console.WriteLine($" Saya sedang makan {input}");


// Operasi bilangan / Tipe Data
// int a= 20;
// float b= 20.9f;
// float c= a + b;
// Console.WriteLine(c);



// Booelan
// Console.WriteLine( 1 == 2);
// Console.WriteLine( 1 > 2);

// int a= 10;
// int b= 10;

// string myValue = "a";
// string myValue2 = "A ";
// string adit = " Adit disuruh ngambil ijazah ";
// Console.WriteLine(b != a);

// Console.WriteLine(!adit.Contains("ijazah"));
// Console.WriteLine(!adit.Contains("ijazah")== false);
// Console.WriteLine(!adit.Contains("Mama"));


// Console.WriteLine(myValue2 == "a");
// Console.WriteLine(myValue.ToLower().Trim() == myValue2.ToLower().Trim());

//conditional operator
// int hargaJual= 600;
// int discount = hargaJual > 1000 ? 80 : 30;
// Console.WriteLine($"Discount yang didapat adalah {discount}");
// Console.WriteLine($"Discount : {(hargaJual > 1000 ? 80:30)}");


// Random Number
// Random coin = new Random();
// int flip = coin.Next(0,2);
// Console.WriteLine((flip == 0) ? "Heads" : "Tails");

//Decision Logic
/* string permission = "Admin|Manager";
int level = 55;
if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome Super Admin");
    }
    else
    {  
        Console.WriteLine("Admin Biasa");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
     Console.WriteLine("Contact admin for access");
    }
    else
    {
        Console.WriteLine("Kamu tidak punya akses");
    }
    {
        Console.WriteLine("HOHO");
}
}
else
{
    Console.WriteLine("You dont have access");
} */









// Console.WriteLine("Do you want continue this program ? (y/n)");
// string input = Console.ReadLine();

//===========================================================================//
// CODE BLOCK================================================================

// bool flag= true;
// int value = 5;
// if (true)
// {
//     value = 6;
//     Console.WriteLine($"Inside the code block: {value}");
// }
// Console.WriteLine($"Outside the code block: {value}");

//clean code ifelse
// string name = "Jefri";
// bool flag = true;

// if (name == "Jefri") 
//     Console.WriteLine("Found Jefri");
// else if (name == "Septi") 
//     Console.WriteLine("found Septi");
// else
//      Console.WriteLine("Not found");
        
int[] numbers = { 4 , 8, 15, 16, 23, 89 };
int total = 0;
bool found = true;

foreach (int number in numbers)
{

    total += number;

if (number == 42)
    found = true;
        
}
 if (found)   
Console.WriteLine("Set Contains 42");

   
Console.WriteLine($"Total : {total}");

