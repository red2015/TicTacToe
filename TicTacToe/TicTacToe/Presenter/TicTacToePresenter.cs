using System;
using System.Windows.Forms;
using TicTacToe.Model.Game;
using TicTacToe.Model.NeuralNetwork;
using TicTacToe.Model.Paint;
using TicTacToe.View;

namespace TicTacToe.Presenter
{
    class TicTacToePresenter
    {
        private readonly Func<TicTacToeForm> _form;
        private IGameFacade _gameFacade;
        private IPaintFacade _paintFacade;
        private INeuralNetworkFacade _networkFacade;

        public TicTacToePresenter(Func<TicTacToeForm> form, IGameFacade gameFacade, IPaintFacade paintFacade, INeuralNetworkFacade networkFacade)
        {
            _form = form;
            _gameFacade = gameFacade;
            _paintFacade = paintFacade;
            _networkFacade = networkFacade;
        }

        public void RunApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(_form());
        }
    }
}
