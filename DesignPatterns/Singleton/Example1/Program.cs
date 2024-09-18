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
            Singleton fromTeacher = Singleton.GetInstance(); //without lazy initialization
            //Singleton fromTeacher = Singleton.Instance; //with lazy initialization
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.GetInstance();//without lazy initialization
            //Singleton fromStudent = Singleton.Instance;//with lazy initialization
            fromStudent.PrintDetails("From Student");
        }
    }
}
