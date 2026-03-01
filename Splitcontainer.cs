using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Act_1._4___Wiki___Controls
{
    public partial class Splitcontainer : Form
    {
        public Splitcontainer()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            // Fixem la mida del panell esquerre (ex: per a un menú)
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.SplitterDistance = 200;

            // Afegim un estil visual perquè es vegi el separador
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;

            // Podem canviar el color dels panells per identificar-los
            splitContainer1.Panel1.BackColor = Color.LightGray;
            splitContainer1.Panel2.BackColor = Color.White;
        }
    }
}
