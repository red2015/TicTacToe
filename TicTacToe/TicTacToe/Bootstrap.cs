using System.Reflection;
using System.Windows.Forms;
using Autofac;
using TicTacToe.Model.Game;
using TicTacToe.Model.NeuralNetwork;
using TicTacToe.Model.Paint;
using TicTacToe.Presenter;

namespace TicTacToe
{
    internal class Bootstrap
    {
        public static IApp Initializate()
        {
            ContainerBuilder builder = new ContainerBuilder();

            var assembly = Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                .Where(type => type.IsSubclassOf(typeof(Form)));

            builder.RegisterType<GameFacade>().As<IGameFacade>();
            builder.RegisterType<NeuralNetworkFacade>().As<INeuralNetworkFacade>();
            builder.RegisterType<PaintFacade>().As<IPaintFacade>();
            builder.RegisterType<TicTacToePresenter>();
            builder.RegisterType<App>().As<IApp>();

            var container = builder.Build();
            return container.Resolve<IApp>();
        }
    }
}
