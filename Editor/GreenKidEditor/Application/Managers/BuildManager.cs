using System.Collections.Generic;

namespace GreenKidEditor.Application.Managers
{
    public static class BuildManager
    {
        public static string CurrentPlatform { get; set; }
        public static List<string> Platforms { get; }

        static BuildManager()
        {
            Platforms = new List<string>
            {
                "Windows", "Android", "iOS"
            };
        }
    }
}