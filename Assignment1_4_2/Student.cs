namespace Assignment1_4_2
{
    // 2. Write a class: "Student" with private data members:
    // StudentId (int), StudentFname (string), StudentLname (string), StudentGrade (char)
    // and public properties for each data member.
    public class Student
    {
        // Private data members
        private int studentId;
        private string studentFname;
        private string studentLname;
        private char studentGrade;

        // Default constructor
        public Student()
        {
            studentId = 0;
            studentFname = string.Empty;
            studentLname = string.Empty;
            studentGrade = ' ';
        }

        // Public properties for each data member
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string StudentFname
        {
            get { return studentFname; }
            set { studentFname = value; }
        }

        public string StudentLname
        {
            get { return studentLname; }
            set { studentLname = value; }
        }

        public char StudentGrade
        {
            get { return studentGrade; }
            set { studentGrade = value; }
        }
    }
}
