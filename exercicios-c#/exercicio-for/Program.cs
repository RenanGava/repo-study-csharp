

// primeiro exercicio resolvido
// int x = 8;

// for(int i = 0; i < x; i++){

//     if(i % 2 == 1){
//         Console.WriteLine($"Número impar {i}");
//     }
// }

Console.WriteLine("Digite os numeros aqui");
string[] numbers = Console.ReadLine().Split(" ");

int countNumberIn = 0;
int countNumberOut = 0;


for(int i = 0; i < numbers.Length; i++){
    if(int.Parse(numbers[i]) >= 10 && int.Parse(numbers[i]) <= 20){
        countNumberIn++;
        Console.WriteLine($"{numbers[i]} in");
    }
    else{
        countNumberOut++;
        Console.WriteLine($"{numbers[i]} out");
    }
}

System.Console.WriteLine(countNumberIn);
System.Console.WriteLine(countNumberOut);
