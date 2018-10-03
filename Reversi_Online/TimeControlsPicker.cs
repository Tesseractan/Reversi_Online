using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi_Online
{
    public partial class TimeControlsPicker : UserControl
    {
        private int checkedCount, uncheckedCount;
        private readonly CheckBox[] checkboxes;
        public TimeControlsPicker()
        {
            InitializeComponent();
            this.checkboxes = new CheckBox[9]
            {
                Checkbox_1min, Checkbox_2min, Checkbox_3min, Checkbox_5min, Checkbox_10min, Checkbox_15min, Checkbox_20min, Checkbox_30min, Checkbox_1h
            };
            this.uncheckedCount = this.checkboxes.Length;
        }

        private void TimeControlsPicker_Load(object sender, EventArgs e)
        {
            
            foreach (CheckBox checkbox in time_control_groupbox.Controls)
            {
                checkbox.CheckedChanged += (s, ea) =>
                {
                    if (checkbox.Checked)
                    {
                        checkbox.BackColor = Color.Orange;
                        this.uncheckedCount.Transfer(1, ref this.checkedCount);
                    }
                    else
                    {
                        checkbox.BackColor = SystemColors.Control;
                        this.checkedCount.Transfer(1, ref this.uncheckedCount);
                    }
                };
            }
        }

        #region properties
        public int CheckedCount => this.checkedCount;
        public int UncheckedCount => this.uncheckedCount;
        public bool NothingSelected => checkedCount == 0;
        public bool EverythingSelected => uncheckedCount == 0;
        public CheckBox[] Checkboxes => this.checkboxes;
        public CheckBox Checkbox_1min => checkbox_1min;
        public CheckBox Checkbox_2min => checkbox_2min;
        public CheckBox Checkbox_3min => checkbox_3min;
        public CheckBox Checkbox_5min => checkbox_5min;
        public CheckBox Checkbox_10min => checkbox_10min;
        public CheckBox Checkbox_15min => checkbox_15min;
        public CheckBox Checkbox_20min => checkbox_20min;
        public CheckBox Checkbox_30min => checkbox_30min;
        public CheckBox Checkbox_1h => checkbox_1h;
        #endregion
    }
}
