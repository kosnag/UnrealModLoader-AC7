﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Sojaner.MemoryScanner;
using System.Numerics;
using System.IO;
using System.IO.MemoryMappedFiles;


namespace GenericTelemetryProvider
{


    public partial class MainForm : Form
    {

        Dirt5UI dirt5UI;
        FilterUI filterUI;

        public MainForm()
        {
            InitializeComponent();

        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Dirt5Button_Click(object sender, EventArgs e)
        {
            if (dirt5UI == null)
            {
                dirt5UI = new Dirt5UI();

                Thread x = new Thread(new ParameterizedThreadStart((form) => ((Dirt5UI)form).ShowDialog()));
                x.Start(dirt5UI);
            }

        }

        private void Filters_Click(object sender, EventArgs e)
        {
            if (filterUI == null)
            {
                filterUI = new FilterUI();

                Thread x = new Thread(new ParameterizedThreadStart((form) => 
                { 
                    ((FilterUI)form).ShowDialog();
                }));
                x.Start(filterUI);
            }
        }
    }
}
