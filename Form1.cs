using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace designPaint
{
    public enum ButtonColor
    {
        Left,
        Right
    }

    public enum ShapeMode
    {
        Line,
        FillEllipse,
        DrawEllipse,
        FillRectangle,
        DrawRectange,
        DrawTriangular 
    }

    public partial class Form1 : Form
    {  
        /// <summary>
        ///     Tọa độ chuột tại điểm bấm đầu tiên
        /// </summary>
        public Point _p1;
        private Point _p2;
        private bool _isDown;
        private Bitmap _bm;//ke thua tu 1 image
        private Graphics _grs;
        private ButtonColor _currButtonColor;
        private Color _currLeftColor; 
        private int _currPenSize;
        private Color _currRightColor;
        private ShapeMode _currShapMode;
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Thiet_MouseMove;
            this.MouseUp += Form1_MouseUp;
            this.Paint += Form1_Paint;
            _bm = new Bitmap(this.Width, this.Height);//tao mot Bitmap
            _grs = Graphics.FromImage(_bm);

            //_currButtonColor = ButtonColor.Left;
            _currLeftColor = Color.Black;
            _currRightColor = Color.White;
            _currShapMode = ShapeMode.Line;
            _currButtonColor = ButtonColor.Left;

            //giam hien tuong rung cua form
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //them vao Item cho combobox
            InitComboBoxSize();
        }


        private void InitComboBoxSize()
        {
            for (int i = 1; i <= 10; i++)
            {
                cmbSize.Items.Add(i);
            }
            cmbSize.SelectedIndex = 0;
        }
         void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(_isDown)
            {
                Pen pen;
                SolidBrush sb;
                int dx = _p2.X - _p1.X;
                int dy = _p2.Y - _p1.Y;
                switch(_currShapMode)
                {
                    case ShapeMode.Line:
                        pen = new Pen(_currLeftColor, (float)_currPenSize);
                        e.Graphics.DrawLine(pen, _p1, _p2);
                        break;

                    case ShapeMode.DrawEllipse:
                        pen = new Pen(_currLeftColor, (float)_currPenSize);
                        e.Graphics.DrawEllipse(pen, _p1.X, _p1.Y,dx,dy);
                        break;

                    case ShapeMode.FillEllipse:
                        sb = new SolidBrush(_currLeftColor);
                        e.Graphics.FillEllipse(sb, _p1.X, _p1.Y, dx, dy);
                        break;

                    case ShapeMode.DrawRectange:
                        pen = new Pen(_currLeftColor, (float)_currPenSize);
                        e.Graphics.DrawRectangle(pen, _p1.X, _p1.Y,dx,dy);
                        break;


                    case ShapeMode.FillRectangle:
                        sb = new SolidBrush(_currLeftColor);
                        e.Graphics.FillRectangle(sb, _p1.X, _p1.Y, dx, dy);
                        break;
                    default:
                        MessageBox.Show("Loi");
                        break;
                }
            }
        }

        void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _isDown = false;
            Pen pen;
            SolidBrush sb;
            int dx = _p2.X - _p1.X;
            int dy = _p2.Y - _p1.Y;
            switch (_currShapMode)
            {
                case ShapeMode.Line:
                    pen = new Pen(_currLeftColor, (float)_currPenSize);
                    _grs.DrawLine(pen, _p1, _p2);
                    break;

                case ShapeMode.DrawEllipse:
                    pen = new Pen(_currLeftColor, (float)_currPenSize);
                    _grs.DrawEllipse(pen, _p1.X, _p1.Y, dx, dy);
                    break;

                case ShapeMode.FillEllipse:
                    sb = new SolidBrush(_currLeftColor);
                    _grs.FillEllipse(sb, _p1.X, _p1.Y, dx, dy);
                    break;

                case ShapeMode.DrawRectange:
                    pen = new Pen(_currLeftColor, (float)_currPenSize);
                    _grs.DrawRectangle(pen, _p1.X, _p1.Y, dx, dy);
                    break;

                case ShapeMode.FillRectangle:
                    sb = new SolidBrush(_currLeftColor);
                    _grs.FillRectangle(sb, _p1.X, _p1.Y, dx, dy);
                    break;
                default:
                    MessageBox.Show("Loi");
                    break;
            }
            this.BackgroundImage = (Bitmap)_bm.Clone();
        }

        void Thiet_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDown)
            {
                _p2 = new Point(e.Location.X, e.Location.Y);
                this.Refresh();
            }
        }

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _isDown = true;
            _p1 = new Point(e.Location.X, e.Location.Y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //sự kiện thoát
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //sự kiện chọn màu.
        private void btnChonMau_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if(cld.ShowDialog()==DialogResult.OK)
            {
                if(_currButtonColor==ButtonColor.Left)
                {
                    btnMauTrai.BackColor = cld.Color;
                    // _currButtonColor = ButtonColor.Left;
                    _currLeftColor = cld.Color;
                }
               else if (_currButtonColor == ButtonColor.Right)
                {
                    btnMauPhai.BackColor = cld.Color;
                    _currRightColor = cld.Color;
                  
                }
                _currRightColor = cld.Color;
            }
        }

        private void btnMauTrai_Click(object sender, EventArgs e)
        {
            _currButtonColor = ButtonColor.Left;
        }

        private void btnMauPhai_Click(object sender, EventArgs e)
        {

            _currButtonColor = ButtonColor.Right;
       
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currPenSize = int.Parse(cmbSize.Text);
        }

        private void btnDuongThang_Click(object sender, EventArgs e)
        {
            _currShapMode = ShapeMode.Line;
        }

        private void btnHinhTron_Click(object sender, EventArgs e)
        {
            _currShapMode = ShapeMode.FillEllipse;
        }

        private void btnHinhChuNhat_Click(object sender, EventArgs e)
        {
            _currShapMode = ShapeMode.DrawRectange;
        }

        private void btnDuongTron_Click(object sender, EventArgs e)
        {
            _currShapMode = ShapeMode.DrawEllipse;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _bm = new Bitmap(this.Width, this.Height);
            _grs = Graphics.FromImage(_bm);
            this.Refresh();
            this.BackgroundImage = (Bitmap)_bm.Clone();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
