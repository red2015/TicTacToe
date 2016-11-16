using System;
using System.Drawing;
using System.Windows.Forms;
using Core.Paint.Canvases;

namespace TicTacToe.View
{
    public partial class TicTacToeForm : Form
    {
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        public event Action<CanvasType, Point> StartPainting;
        public event Action<CanvasType, Point> StopPainting;
        public event Action<CanvasType, Point> ContinuePainting;

        private void pbLearning_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var canvasType = GetCanvasType(sender);
                StartPainting?.Invoke(canvasType, e.Location);
            }
        }
        
        private void pbLearning_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var canvasType = GetCanvasType(sender);
                ContinuePainting?.Invoke(canvasType, e.Location);
            }
        }

        private void pbLearning_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var canvasType = GetCanvasType(sender);
                StopPainting?.Invoke(canvasType, e.Location);
            }
        }

        private static CanvasType GetCanvasType(object sender)
        {
            var pictureBox = sender as PictureBox;
            var canvasType = EnumUtil.ParseEnum<CanvasType>(pictureBox?.Name);
            return canvasType;
        }
    }
}
