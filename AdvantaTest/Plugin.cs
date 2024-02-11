using System.Drawing;

namespace ds.test.impl
{
    internal class Plugin : BasePlugin
    {
        public Plugin(string pluginName, Image image, string description, Func<int,int,int> func) 
        {
            PluginName = pluginName;
            Image = image;
            Description = description;
            runFunc = func;

        }
        public override string PluginName { get; set; }

        public override Image Image {get; set;}

        public override string Description { get; set;}

        public override Func<int, int, int> runFunc { get; set; }

    }
}
