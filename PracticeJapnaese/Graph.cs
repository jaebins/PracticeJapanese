using PracticeJapnaese.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapanesePractice
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            Image image = Resources.graph;
            SetClientSizeCore(image.Width, image.Height);
            graph_picture.Size = new Size(image.Width, image.Height);
        }
    }
}