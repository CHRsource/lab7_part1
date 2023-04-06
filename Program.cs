//WorkerFix person1 = new();
//person1.PrintAll();
//person1.InputSalary();
//person1.InputPrizePercent();
//person1.PrintAll();
//WorkerFix person2 = new("Иванова", "Кристина", new DateTime(2003, 12, 11), 'Ж', 200000, 30);
//person2.PrintAll();
//Console.WriteLine("Общая сумма заработной платы с учетом премии = " + person2.SalaryWithPrize());
//Console.WriteLine("Подоходный налог = " + person2.Tax());
//Console.WriteLine("Сумма, выдаваемая на руки, за вычетом налога = " + person2.Income());

WorkerHourly per1 = new();
per1.PrintAll();
per1.InputAll();
per1.PrintAll();
WorkerFix[] array = new WorkerFix[] {
    new WorkerFix("Петров", "Андрей", new DateTime(1999, 1, 31), 'М', 15000, 20),
    new WorkerFix("Павловская", "Ольга", new DateTime(1983, 4, 20), 'Ж', 200000, 35),
    new WorkerHourly("Абдрахманов", "Амир", new DateTime(2005, 11, 30), 'М', 120, 15, 180),
    new WorkerHourly("Филлимонова", "Виктория", new DateTime(2003, 8, 13), 'Ж', 150, 20, 144)
};
static double SumIncome(WorkerFix[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += array[i].SalaryWithPrize();
    return Math.Round(sum, 2);
}
static double SumTax(WorkerFix[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += array[i].Tax();
    return Math.Round(sum, 2);
}
static WorkerFix MaxIncome(WorkerFix[] array)
{
    int max_ind = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i].Income() > array[max_ind].Income())
            max_ind = i;
    }
    return array[max_ind];
}
Console.WriteLine("Общая сумма, начисленная работникам = " + SumIncome(array));
Console.WriteLine("Общая сумма уплаченных налогов = " + SumTax(array));
Console.WriteLine("Данные работника с наибольшей полученной на руки суммой");
MaxIncome(array).PrintAll();

