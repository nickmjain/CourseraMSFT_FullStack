class Student
{
    // Each student will have a name and ID, which are instance variables
    // Each student can have multiple subjects and multiple grades
    public string Name { get; set; }
    public string ID { get; set; }
    private Dictionary<string, int> grades;

    public Student(string name, string id)
    {
        Name = name;
        ID = id;
        grades = new Dictionary<string, int>();
    }

    // Function to set a grade for a given subject
    public void SetGrade(string subject, int grade)
    {
        if (grade < 0 || grade > 100)
        {
            throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");
        }
        grades[subject] = grade;
    }

    // Function to get a grade for a given subject
    public int GetGrade(string subject)
    {
        if (grades.ContainsKey(subject))
        {
            return grades[subject];
        }
        else
        {
            throw new KeyNotFoundException("No grade found for specified subject");
        }
    }

    // Function to return all grades
    public void GetAllGrades()
    {
        foreach (var grade in grades)
        {
            Console.WriteLine($"Subject: {grade.Key}, Grade: {grade.Value}");
        }
    }

    // Function to return the average grade
    public double GetAverageGrade()
    {
        double sum = 0;
        foreach (var grade in grades)
        {
            sum += grade.Value;
        }
        return sum / grades.Count;
    }

    // Display all student information
    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Student ID: {ID}");
        Console.WriteLine("Grades by subject:");
        GetAllGrades();
        Console.WriteLine($"Average Grade: {GetAverageGrade()}");
    }
}
