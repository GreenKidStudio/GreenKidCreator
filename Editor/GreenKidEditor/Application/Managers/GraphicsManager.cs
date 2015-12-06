using System.Collections.Generic;

namespace GreenKidEditor.Application.Managers
{
    public static class GraphicsManager
    {
        public static int Samples { get; set; }
        public static IEnumerable<int> SamplesValues { get; }

        public static bool UseSamplesInBuild { get; set; }

        static GraphicsManager()
        {
            SamplesValues = new[]
            {
                0, 2, 4, 8, 16, 32
            };
        }

        public static void LoadSettings()
        {
        }

        public static void SaveSettings()
        {
        }
    }
}