namespace CoursesWebApp.Models
{
    public class CoursesAndModules
    {
        // TODO: Define the CourseName, ModuleTitle, and Sequence read-only properties
        public string CourseName { get; }
        public string ModuleTitle { get; }
        public int Sequence { get; }

        // TODO: Create a constructor that initializes the fields behind the properties
        public CoursesAndModules(string courseName, string moduleTitle, int sequence)
        {
            this.CourseName = courseName;
            this.ModuleTitle = moduleTitle;
            this.Sequence = sequence;
        }
    }
}
