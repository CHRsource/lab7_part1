#pragma warning disable
using cs_lab7;

class Person : ICLIable
{
    public string Surname { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    private char sex;
    public char Sex
    {
        get { return sex; }
        private set
        {
            if (value == 'Ж' | value == 'М')
                sex = value;
            else sex = 'Ж';
        }
    }
    public Person(Person person) : this(person.Surname, person.Name, person.Birthday, person.Sex)
    { }
    public Person() : this("Undefined", "Undefined", new DateTime(2000, 1, 1), 'Ж')
    { }
    public Person(string surname, string name, DateTime birthday, char sex)
    {
        Surname = surname;
        Name = name;
        Birthday = birthday;
        Sex = sex;
    }

    public string ToString()
    {
        if (Sex == 'М') return "мужской";
        else return "женский";
    }
    public void Print(object some) { Console.WriteLine(Convert.ToString(some)); }
    public virtual void PrintAll()
    {
        Console.Write("Фамилия: ");
        Print(Surname);
        Console.Write("Имя: ");
        Print(Name);
        Console.Write("Дата рождения: ");
        Print(Birthday);
        Console.Write("Пол: ");
        Console.WriteLine(ToString());
        Console.Write("Возраст: ");
        Print(Age());
    }
    public virtual void InputAll()
    {
        InputSurname();
        InputName();
        InputBirthday();
        InputSex();
    }
    public void InputSurname()
    {
        Console.Write("Введите фамилию: ");
        Surname = Console.ReadLine();
    }
    public void InputName()
    {
        Console.Write("Введите имя: ");
        Name = Console.ReadLine();
    }
    public void InputBirthday()
    {
        Console.Write("Введите дату рождения: ");
        Birthday = Convert.ToDateTime(Console.ReadLine());
    }
    public void InputSex()
    {
        char extra;
        while (true)
        {
            Console.Write("Введите пол: ");
            extra = Convert.ToChar(Console.ReadLine());
            if (extra == 'М' | extra == 'Ж') break;
            Console.WriteLine("Допустимые значения 'М' или 'Ж'. Повторите ввод.");
        }
        Sex = extra;
    }
    public int Age()
    {
        DateTime now = DateTime.Now;
        int age = now.Year - Birthday.Year;
        if (Birthday > now.AddYears(-age)) age--;
        return age;
    }
}

