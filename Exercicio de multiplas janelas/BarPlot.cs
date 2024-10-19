using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_de_multiplas_janelas
{
    public partial class BarPlot : UserControl
    {
        private int BarMaxHeight { get { return (int) (this.Height * 0.8); } }
        private int BorderWidht { get; set; }
        private int SpaceBetween { get; set; }
        private int BarWidth {  get; set; }

        private List<string> _labels;
        public List<string> Labels 
        {
            get => _labels;
            set 
            {
                _labels = value;
                this.OnLabelsOrValuesChanged(this, new EventArgs());
            }
        } 

        private List<double> _values;
        public List<double> Values
        {
            get { return _values; }
            set
            {
                _values = value;
                this.OnLabelsOrValuesChanged(this, new EventArgs());
            }
        }

        public BarPlot(List<string>labels, List<double>values)
        {
            InitializeComponent();
            if(labels != null) this.Labels = labels;
            else this.Labels = new List<string>();

            if(values != null) this.Values = values;
            else this.Values = new List<double>();
        }

        public void OnLabelsOrValuesChanged(object sender, EventArgs e) 
        {
            for (int i = 0; i < this.Labels.Count; i++)
            {
                Label label = new Label();
                label.Text = this.Labels[i];
                label.Left = (i * BarWidth) + (i * SpaceBetween) + BorderWidht;
                label.Top = 10;
                this.Controls.Add(label);
            }

            for (int i = 0; i < this.Values.Count; i++)
            {
                Panel r = new Panel();
                r.Left = (i * BarWidth) + (i * SpaceBetween) + BorderWidht;
                r.Width = BarWidth;
                r.Height = (int)((Values[i] / Values.Max()) * BarMaxHeight);
                r.Top = Height - r.Height;
                r.BackColor = Color.Blue;
                this.Controls.Add(r);
            }
        }
    }
}
