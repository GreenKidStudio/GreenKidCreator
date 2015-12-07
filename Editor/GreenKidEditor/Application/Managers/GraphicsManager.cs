using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace GreenKidEditor.Application.Managers
{
    public static class GraphicsManager
    {
        public static int Samples { get; set; }
        public static IEnumerable<int> SamplesValues { get; }

        public static bool UseSamplesInBuild { get; set; }

        public static string OpenGL { get; set; }
        public static string GLSL { get; set; }

        static GraphicsManager()
        {
            SamplesValues = new[]
            {
                0, 2, 4, 8, 16, 32
            };
        }

        private static void UseDefaultSettings()
        {
            Samples = SamplesValues.First();
        }

        public static void LoadSettings()
        {
            const string file = "Bin/Settings.xml";

            if (!File.Exists(file))
            {
                UseDefaultSettings();

                return;
            }

            using (var reader = XmlReader.Create(file))
            {
                while (reader.Read())
                {
                    if (reader.NodeType != XmlNodeType.Element)
                        continue;

                    if (reader.Name != "Render")
                        continue;

                    UseSamplesInBuild = Convert.ToBoolean(reader.GetAttribute("BuildOnly"));
                    Samples = Convert.ToInt32(reader.GetAttribute("Samples"));
                }
            }
        }

        public static void SaveSettings()
        {
            if (!Directory.Exists("Bin"))
            {
                Directory.CreateDirectory("Bin");
            }

            using (var writer = XmlWriter.Create("Bin/Settings.xml", new XmlWriterSettings { Indent = true, IndentChars = ("\t"), OmitXmlDeclaration = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Settings");

                writer.WriteStartElement("Render");
                writer.WriteAttributeString("BuildOnly", UseSamplesInBuild.ToString());
                writer.WriteAttributeString("Samples", Samples.ToString());

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}