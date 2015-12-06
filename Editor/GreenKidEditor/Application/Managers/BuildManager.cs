using System.Collections.Generic;

namespace GreenKidEditor.Application.Managers
{
    public static class BuildManager
    {
        public static string CurrentPlatform { get; set; }
        public static IEnumerable<string> Platforms { get; }

        static BuildManager()
        {
            Platforms = new []
            {
                "Windows", "Android", "iOS"
            };
        }
    }
}