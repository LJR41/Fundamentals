
// for (int i = 0; i <= 255; i++)
// {
//     Console.WriteLine(i);
// }

Random number = new();

// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(number.Next(10,21));
// }
int sum = 0;

for (int i = 1; i <= 5; i++)
{
    int random = number.Next(10,21);
    Console.WriteLine(random);
    sum += random;

}

Console.WriteLine(sum);

// for (int i = 1; i <= 100; i++)
// {
//     if(i % 3 == 0 && i % 5 != 0){
//         Console.WriteLine(i);
//     } 
//     else if(i % 5 == 0 && i % 3 != 0){
//         Console.WriteLine(i);
//     }
// }

// for (int i = 1; i <= 100; i++)
// {
//     if(i % 3 == 0 && i % 5 != 0){
//         Console.WriteLine("Fizz");
//     } 
//     else if(i % 5 == 0 && i % 3 != 0){
//         Console.WriteLine("Buzz");
//     }
// }

for (int i = 1; i <= 100; i++)
{
    if(i % 3 ==0 && i % 5 ==0){
        Console.WriteLine($"FizzBuzz {i}");
    }
    if(i % 3 == 0 && i % 5 != 0){
        Console.WriteLine($"Fizz {i}");
    } 
    else if(i % 5 == 0 && i % 3 != 0){
        Console.WriteLine($"Buzz {i}");
    }
}