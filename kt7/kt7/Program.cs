struct Student
{
    public string name;
    public string surname;
    public int age;
    public int course;
    public int studentbook;
    public string form;

    public void Show()
    {
        Console.WriteLine("Имя" + name + "Фамилия" + surname + "Возраст" + age + "Курс обучения" + course + "Номер зачетной книги" + studentbook + "Форма обучения" + form);
    }
    public void InputInfo()
    {
        name = "Alex";
        surname = "Frolov";
        age = 18;
        course = 1;
        studentbook = 854648875;
        form = "Зачная";

    }
    public void Create()
    {
        Console.WriteLine("Введите имя");
        name = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Введите фамилию");
        surname = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Введите возраст");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите курс обучения");
        course = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер зачетной книжки");
        studentbook = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите форму обучения");
        form = Convert.ToString(Console.ReadLine());

    }
}
class Program
{
    static void Menu()
    {
        Console.WriteLine("1. Добавить нового студента в группу");
        Console.WriteLine("2. Добавить нового студента в группу со стандартными значениями");
        Console.WriteLine("3. Просмотр списка группы");
        Console.WriteLine("4. Удаление студента из группы");
        Console.WriteLine("5. Выход");
    }

    static void Main(string[] args)
    {
        List<Student> allstudent = new List<Student>();
        string input;
        do
        {
            Console.WriteLine("Выберите пункт");
            Menu();
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Вы выбрали (Добавить нового студента в группу)");
                Student student = new Student();
                student.Create();
                allstudent.Add(student);

            }
            else if (input == "2")
            {
                Console.WriteLine("Вы выбрали(Добавить нового студента в группу со стандартными значениями)");
                Student student = new Student();
                student.InputInfo();
                allstudent.Add(student);
            }
            else if (input == "3")
            {
                Console.WriteLine("Вы выбрали (Просмотр списка группы)");
                foreach (var el in allstudent)
                {
                    el.Show();
                }

            }
            else if (input == "4")
            {
                Console.WriteLine("Вы выбрали (Удаление студента из группы по номеру зачетной книжки)");
                Console.WriteLine("Напишите номер зачетной книжки студента, которого хотите удалить");
                int delete = Convert.ToInt32(Console.ReadLine());
                var i = 0;
                var deleteStudentIndex = -999;
                foreach (var el in allstudent)
                {
                    if (el.studentbook == delete)
                    {
                        deleteStudentIndex = i;

                    }
                    i++;
                }
                if (deleteStudentIndex != -999)
                {
                    allstudent.RemoveAt(deleteStudentIndex);
                }
                else
                {
                    Console.WriteLine("Такого студента нет");
                }


            }
        }
        while (input != "5");
    }

}