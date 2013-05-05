using System;
using System.IO;
using System.Reflection;

namespace MCDynamite.API
{
    public class PluginManager
    {
        public PluginManager() 
        { 
        }

        public Assembly assembly_ { get; set; }
        public Plugin plugin_ { get; set; }
        public String pluginname_ { get; set; }
        public String pluginversion_ { get; set; }
        public String pluginauthor_ { get; set; }

        public static void Load(string plugin)
        {
            PluginManager pm = new PluginManager();

            string fullPath = Path.GetFullPath(String.Format("plugins/{0}.dll", plugin));
            pm.assembly_ = Assembly.LoadFile(fullPath);

            foreach (Type type in pm.assembly_.GetTypes())
            {
                if (type.BaseType == typeof(Plugin))
                {
                    pm.plugin_ = (Plugin)Activator.CreateInstance(type);
                    Server.getServer().plugins.Add(pm.plugin_);
                    break;
                }
            }

            if (plugin == null)
                throw new Exception("Could not find child class of Plugin in DLL.");

            pm.pluginname_ = pm.plugin_.name;
            pm.pluginversion_ = pm.plugin_.version;
            pm.pluginauthor_ = pm.plugin_.author;
        }

        public static void EnableAllPlugins()
        {
            foreach (Plugin p in Server.getServer().plugins)
            {
                p.onEnable();
            }
        }

        public static void DisableAllPlugins()
        {
            foreach (Plugin p in Server.getServer().plugins)
            {
                p.onDisable();
            }
        }

        public static void AutoLoadPlugins()
        {
            if (!File.Exists("text/plugins.txt"))
                File.Create("text/plugins.txt").Close();
            foreach (string p in File.ReadAllLines("text/plugins.txt"))
            {
                PluginManager.Load(p);
            }
        }
    }
}