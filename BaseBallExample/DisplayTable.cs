using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace BaseBallExample
{
    public partial class DisplayTable : Form
    {
        public DisplayTable()
        {
            InitializeComponent();
        }

        //Entity Framework DB content
        private BaseBallExample.BaseballEntities dbcontext
            = new BaseBallExample.BaseballEntities();

        private void DisplayTable_Load(object sender, EventArgs e)
        {
            dbcontext.P
        }
    }
}
