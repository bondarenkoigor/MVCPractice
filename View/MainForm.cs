﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCPractice.Control;

namespace MVCPractice.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ContactController Controller = new ContactController();
            InitializeComponent();
            this.ContactsListBox.Items.AddRange(Controller.Contacts.ToArray());
        }
    }
}
