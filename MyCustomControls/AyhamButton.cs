using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCustomControls
{
    public partial class AyhamButton : Guna2Button
    {
        public enum enButtonStyle { Accept, Cancel, AcceptOutline, CancelOutline }

        public enButtonStyle _ButtonStyle = enButtonStyle.Accept;
        [Category("Options")]
        public enButtonStyle ButtonStyle
        {
            get { return _ButtonStyle; }
            set
            {
                _ButtonStyle = value;
                _ButtonChangeStyle();
            }
        }

        Color _RedColor = Color.FromArgb(239, 68, 68);
        Color _GreenColor = Color.FromArgb(16, 185, 129);
        public AyhamButton()
        {
            InitializeComponent();
            this.Font = new Font(this.Font.FontFamily, 12, FontStyle.Regular);
            this.BorderRadius = 5;
            this.Cursor = Cursors.Hand;
            _ButtonChangeStyle();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void _ButtonChangeStyle()
        {
            switch (_ButtonStyle)
            {
                case enButtonStyle.Accept:
                    this.FillColor = _GreenColor;
                    this.BorderThickness = 0;
                    this.BorderColor = Color.Transparent;
                    break;

                case enButtonStyle.Cancel:
                    this.FillColor = _RedColor;
                    this.BorderThickness = 0;
                    this.BorderColor = Color.Transparent;
                    break;

                case enButtonStyle.AcceptOutline:
                    this.FillColor = Color.Transparent;
                    this.BorderThickness = 2;
                    this.BorderColor = _GreenColor;
                    break;

                case enButtonStyle.CancelOutline:
                    this.FillColor = Color.Transparent;
                    this.BorderThickness = 2;
                    this.BorderColor = _RedColor;
                    break;

            }
        }
    }
}
