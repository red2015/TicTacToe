using System;
using System.Drawing;
using System.Windows.Forms;
using Core.Paint.Canvases;
using TicTacToe.Model.Game;
using TicTacToe.Model.NeuralNetwork;
using TicTacToe.Model.Paint;
using TicTacToe.View;

namespace TicTacToe.Presenter
{
    class TicTacToePresenter
    {
        private readonly TicTacToeForm _form;
        private IGameFacade _gameFacade;
        private IPaintFacade _paintFacade;
        private INeuralNetworkFacade _networkFacade;

        public TicTacToePresenter(TicTacToeForm form, IGameFacade gameFacade, IPaintFacade paintFacade, INeuralNetworkFacade networkFacade)
        {
            _form = form;
            _gameFacade = gameFacade;
            _paintFacade = paintFacade;
            _networkFacade = networkFacade;
            _form.StartPainting += StartPainting;
            _form.ContinuePainting += ContinuePainting;
            _form.StopPainting += StopPainting;

        }

        private void StartPainting(CanvasType canvasType, Point point)
        {
            _paintFacade.StartToPaint(canvasType, point);
        }

        private void ContinuePainting(CanvasType canvasType, Point point)
        {
            _paintFacade.ContinueToPaint(canvasType, point);
        }

        private void StopPainting(CanvasType canvasType, Point point)
        {
            _paintFacade.StopToPaint(canvasType, point);
        }

        public void RunApp()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(_form);
        }
    }
}
