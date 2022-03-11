using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SkarLauncher.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace SkarLauncher
{
    public class Config
    {
        private string directory;
        private string fileName;
        private string filePath;

        public Config()
        {
            directory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\SkarLauncher";
            fileName = "config.json";
            filePath = directory + "\\" + fileName;
        }

        public void initConfig()
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(filePath))
            {

                JObject obj = new JObject();
                obj.Add("installations", new JArray());

                StreamWriter stream = File.CreateText(filePath);
                stream.WriteLine(JsonConvert.SerializeObject(obj));
                stream.Close();


            }
        }

        public string getRawData()
        {
            string s;
            StreamReader reader = new StreamReader(filePath);
            s = reader.ReadToEnd();
            reader.Close();
            return s;
        }

        public void createProfile(string path, string name, Color color, bool jaguar, bool yosemite, bool client, bool memoryfix, bool console, bool harmony, bool lawin, bool noMCP)
        {
            JObject profile = new JObject();
            profile.Add("color", color.R + "," + color.G + "," + color.G);
            profile.Add("path", path);
            profile.Add("name", name);
            profile.Add("jaguar", jaguar);
            profile.Add("yosemite", yosemite);
            profile.Add("client", client);
            profile.Add("memoryfix", memoryfix);
            profile.Add("console", console);
            profile.Add("harmony", harmony);
            profile.Add("lawin", lawin);
            profile.Add("noMCP", noMCP);

            JObject config = JsonConvert.DeserializeObject<JObject>(getRawData());
            JArray arr = (JArray)config["installations"];
            arr.Add(profile);
            config.Remove("installations");
            config.Add("installations", arr);

            File.WriteAllText(filePath, config.ToString());
        }

        public List<Installation> GetInstallations()
        {
            List<Installation> installationsList = new List<Installation>();

            JObject config = JsonConvert.DeserializeObject<JObject>(getRawData());
            JArray array = (JArray)config["installations"];

            foreach(JObject install in array)
            {
                string[] split = install["color"].ToString().Split(',');
                Color color = Color.FromArgb(int.Parse(split[0]), int.Parse(split[1]), int.Parse(split[2]));
                installationsList.Add(new Installation(install["path"].ToString(), install["name"].ToString(), color, (bool)install["jaguar"], (bool)install["yosemite"],
                    (bool)install["client"], (bool)install["memoryfix"], (bool)install["console"], (bool)install["harmony"], (bool)install["lawin"], (bool)install["noMCP"]));
            }


            return installationsList;
        }
    }
}
