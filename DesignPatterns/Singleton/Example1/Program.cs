namespace DesignPatterns.Singleton.Example1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentDetails()
                );
        }

        private static void PrintTeacherDetails()
        {
            Singleton fromTeacher = Singleton.GetInstance();
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.GetInstance();
            fromStudent.PrintDetails("From Student");
        }
    }
}
