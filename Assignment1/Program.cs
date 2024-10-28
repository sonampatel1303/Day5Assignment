namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserpermission student = UserFactory.CreateUser("Student");
            LibraryService studentService = new LibraryService(student);
            studentService.PerformBorrowBook(1);  // This will succeed
            studentService.PerformReserveBook(1); // This will throw an exception since students cannot reserve books
            IUserpermission teacher = UserFactory.CreateUser("Teacher");
            LibraryService teacherService = new LibraryService(teacher);
            teacherService.PerformBorrowBook(1);
            teacherService.PerformReserveBook(1);

        }
    }
}
