Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int n = 1;
for (int i = n; i <= number; i++){
    if(i % 2 == 0){
        Console.WriteLine(i);
    }
}