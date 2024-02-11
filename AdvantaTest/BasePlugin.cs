namespace ds.test.impl
{
    internal abstract class BasePlugin : IPlugin
    {
        public abstract Func<int, int, int> runFunc { get; set; }
        public abstract string PluginName { get; set; }
        public string Version { get;} = "1.0";
        public abstract System.Drawing.Image Image { get; set; }
        public abstract string Description { get; set; }
        public int? Run(int input1, int input2)
        {
            try
            {
                int? output = runFunc.Invoke(input1, input2);
                return output;
            }
            catch { return null; }
        }
    }
}