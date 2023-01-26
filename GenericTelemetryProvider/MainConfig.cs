﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;


namespace GenericTelemetryProvider
{
    class MainConfig
    {
        public static MainConfig Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainConfig();
                }

                return instance;
            }
            set
            {
                instance = value;
            }
        }

        static MainConfig instance;

        public MainConfigData configData = new MainConfigData();

        public static string saveFilename = "Configs\\defaultConfig.txt";
        public bool blockSave = false;

        public void Load()
        {

            if (File.Exists("gtp.txt"))
            {
                string configFilename = File.ReadAllText("gtp.txt");
                if(File.Exists(configFilename))
                {
                    saveFilename = configFilename;
                }
            }

            if (File.Exists(saveFilename))
            {
                string text = File.ReadAllText(saveFilename);

                configData = JsonConvert.DeserializeObject<MainConfigData>(text);
            }
        }

        public void Save()
        {
            string output = JsonConvert.SerializeObject(configData, Formatting.Indented);

            File.WriteAllText(saveFilename, output);
        }

    }

    public class MainConfigData
    {
        public string filterConfig = "Filters\\defaultFilters.txt";

        public string outputConfig = "Outputs\\default_MMF_UDP.txt";

        public class HotkeyConfig
        {
            public Keys key;
            public bool enabled;
            public bool windows;
            public bool alt;
            public bool ctrl;
            public bool shift;
        }

        public HotkeyConfig hotkey = new HotkeyConfig();

    }

}
