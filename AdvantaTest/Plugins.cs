namespace ds.test.impl
{
    public static class Plugins
    {
        internal static List<IPlugin> allPlugins = new List<IPlugin>
        {
            new Plugin("Add",ds.test.impl.Resources.Addition,"Складывает два числа",(input1, input2) => input1 + input2),
            new Plugin("Sub",ds.test.impl.Resources.Subtraction,"Вычитает из первого числа второе",(input1, input2) => input1 - input2),
            new Plugin("Div",ds.test.impl.Resources.Division,"Делит одно число на второе",(input1, input2) => input1 / input2),
            new Plugin("Mult",ds.test.impl.Resources.Multiplication,"Перемножает два числа",(input1, input2) => input1 * input2),
            };
        /// <summary>
        /// Количество доступных плагинов
        /// </summary>
        public static int? PluginsCount => allPlugins?.Count;
        /// <summary>
        /// Метод возвращает названия всех плагинов
        /// </summary>
        /// /// <returns>массив строк - названий плагинов</returns>
        public static string[]? GetPluginNames()
        {
            string[]? pluginNames = new string[(int)PluginsCount];
            for (int i = 0; i < allPlugins.Count; i++)
            {
                pluginNames[i] = allPlugins[i].PluginName;
            }
            return pluginNames;
        }
        /// <summary>
        /// Метод возвращает плагин по названию
        /// </summary>
        /// <param name="pluginName">Название плагина</param>
        /// <returns>объект, реализующий интерфейс IPlugin</returns>
        public static IPlugin? GetPlugin(string pluginName)
        {
            var plugin = allPlugins?.SingleOrDefault(x => x.PluginName == pluginName);
            return plugin is null ? throw new ArgumentNullException("Такого плагина нет") : plugin;
        }

    }
}