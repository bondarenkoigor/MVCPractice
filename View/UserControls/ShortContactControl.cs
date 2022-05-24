using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCPractice.Model;

namespace MVCPractice.View.UserControls
{
    public partial class ShortContactControl : UserControl
    {
        public int ContactId { get; private set; }
        public ShortContactControl()
        {
            InitializeComponent();
        }

        public ShortContactControl(Contact contact) : this()
        {
            this.NameLabel.Text = contact.Name;
            this.SurnameLabel.Text = contact.Surname;
            this.ContactId = contact.id;
        }

    }
}
