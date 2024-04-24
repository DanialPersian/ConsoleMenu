using Danial.Menu;
using Danial.Shapes;

Console.WriteLine("Hello,My names Danial");

//ShapeManager shapeManager = new ShapeManager();
//ShapeManagerMenu menu = new ShapeManagerMenu(shapeManager);
//menu.Select();

List<Student> students = new List<Student>();

students.Add(new Student("Bob"));
students.Add(new Student("Sarah"));
students.Add(new Student("Danial"));

StudentManagerMenu myMenu = new StudentManagerMenu(students);

myMenu.Select();

class StudentManagerMenu : ConsoleMenu
{
    public List<Student> _students;

    public StudentManagerMenu(List<Student> students)
    {
        _students = students;
    }

    public override void CreateMenu()
    {
        _menuItems.Clear();
        foreach(Student student in _students)
        {
            _menuItems.Add(new StudentMenuItem(student));
        }
    }

    public override string MenuText()
    {
        return "Hello Menu";
    }
}

class Student
{
    public string Name;

    public Student(string name) { Name = name; }
}

class StudentMenuItem : MenuItem
{
    private Student _student;

    public StudentMenuItem(Student student)
    {
        _student = student;
    }

    public override string MenuText()
    {
        return $"Student : {_student.Name}";
    }

    public override void Select()
    {
        Console.WriteLine("Enter new name");
        _student.Name = Console.ReadLine();
    }
}


class MyMenuItem : MenuItem
{
    public override string MenuText()
    {
        return "Hello Item";
    }

    public override void Select()
    {
    }
}
