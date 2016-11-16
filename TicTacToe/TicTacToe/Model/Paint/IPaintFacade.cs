using System.Drawing;
using Core.Paint.Canvases;

namespace TicTacToe.Model.Paint
{
    interface IPaintFacade
    {
        void StartToPaint(CanvasType canvasType, Point point);
        void ContinueToPaint(CanvasType canvasType, Point point);
        void StopToPaint(CanvasType canvasType, Point point);
    }
}
