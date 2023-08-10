using FitnessTracker.Classes;
using FitnessTracker.Forms;
using FitnessTracker.Repository;
using FitnessTrackerNet4.Forms;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FitnessTrackerNet4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string rootPath = AppDomain.CurrentDomain.BaseDirectory +"temp.xml" ;

            if (!File.Exists(rootPath))
            {
                CreateFile(rootPath);
                Console.WriteLine("XML file created.");
            }
            else
            {
                Console.WriteLine("XML file already exists.");
            }

            string userString = File.ReadAllText(rootPath);

            User user = null;
            if (userString != "") 
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(userString);
                string jsonText = JsonConvert.SerializeXmlNode(doc,Newtonsoft.Json.Formatting.None,true);
                user = JsonConvert.DeserializeObject<User>(jsonText);
            }
            


            if (user != null)
            {
                FitnessTrackerData.user = user;
                FitnessTrackerForms.IndexForm = new Index();
                Application.Run(FitnessTrackerForms.IndexForm);
            }
            else
            {
                FitnessTrackerForms.WelcomeForm = new Welcome();
                Application.Run(FitnessTrackerForms.WelcomeForm);
            }

        }

        static void CreateFile(string filePath)
        {
            // Create a JSON object or define the JSON content you want to write to the file
            var jsonContent = "";

            // Write the JSON content to the file
            File.WriteAllText(filePath, jsonContent);
        }
    }
}
