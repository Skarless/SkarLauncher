using Newtonsoft.Json.Linq;
using System.Drawing;

namespace SkarLauncher.Utils
{
    public class Installation
    {
        public string name { get; }
        public string path { get; }
        public Color color { get; }
        public bool usingJaguar { get; }
        public bool usingYosemite { get; }
        public bool usingClient { get; }
        public bool usingMemoryFix { get; }
        public bool usingConsole { get; }
        public bool usingHarmony { get; }
        public bool usingLawins { get; }
        public bool noMCP { get; }

        public Installation(string path, string name, Color color, bool jaguar, bool yosemite, bool client, bool memoryfix, bool console, bool harmony, bool lawin, bool noMCP)
        {
            this.name = name;
            this.path = path;
            this.color = color;
            this.usingJaguar = jaguar;
            this.usingYosemite = yosemite;
            this.usingClient = client;
            this.usingMemoryFix = memoryfix;
            this.usingConsole = console;
            this.usingHarmony = harmony;
            this.usingLawins = lawin;
            this.noMCP = noMCP;
        }
    }
}
