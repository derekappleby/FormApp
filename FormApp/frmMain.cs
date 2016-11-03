using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class frmMain : Form
    {
        // ========
        // LIFETIME
        // ========

        public frmMain()
        {
            InitializeComponent();
        }

        // ===
        // DOs
        // ===

        // -------------------------------------------------------------------
        //
        private void DoGoAway()
        {
            this.Close();
        }

        // ================
        // COMMAND HANDLERS
        // ================

        private void cmdGoAway_Click(object sender, EventArgs e) { this.DoGoAway(); }
    }
}
