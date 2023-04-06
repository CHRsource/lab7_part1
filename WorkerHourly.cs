#pragma warning disable
using cs_lab7;

class WorkerHourly : WorkerFix
{
    private int hours;
    public int Hours { get { return hours; } }
    public WorkerHourly(string surname, string name, DateTime birthday, char sex, double salary, double prize_percent, int hours) :
        base(surname, name, birthday, sex, salary, prize_percent)
    {
        this.hours = hours;
    }
    public WorkerHourly() : base()
    {
        this.hours = 0;
    }
    public void InputHours()
    {
        Console.Write("Введите количество отработанных часов: ");
        hours = int.Parse(Console.ReadLine());
    }
    public override void PrintAll()
    {
        base.PrintAll();
        Console.Write("Число отработанных часов: ");
        Print(hours);
        Console.WriteLine();
    }
    public override void InputAll()
    {
        base.InputAll();
        InputHours();
    }
    public override double SalaryWithPrize() { return Math.Round((Salary + Salary * PrizePercent / 100) * hours, 2); }
}
