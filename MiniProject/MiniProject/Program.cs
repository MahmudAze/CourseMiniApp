using Service.Helper;

namespace MiniProject
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        private static void GetMenuOptions()
        {
            Helper.ColorWrite(ConsoleColor.Cyan, "Options:");
            Helper.ColorWrite(ConsoleColor.Cyan, "1. Manage Students");
            Helper.ColorWrite(ConsoleColor.Cyan, "2. Manage Course Groups");
            Helper.ColorWrite(ConsoleColor.Cyan, "0. Exit");
            Helper.ColorWrite(ConsoleColor.Cyan, "Choose the option: ");
        }
        private static void ManageStudents()
        {
            // Implementation for managing students
        }
        private static void ManageCourseGroups()
        {
            // Implementation for managing course groups
        }
    }
}
