using TicTacToe.Presenter;

namespace TicTacToe
{
    class App : IApp
    {
        private readonly TicTacToePresenter _presenter;

        public App(TicTacToePresenter presenter)
        {
            _presenter = presenter;
        }

        public void Run()
        {
            _presenter.RunApp();
        }
    }
}
