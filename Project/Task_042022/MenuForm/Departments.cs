﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_042022.MenuForm
{
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }

        private void Departments_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
