using System;
using System.Windows.Forms;

namespace NeuralNetworks
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainForm _form1View = new mainForm();
            Model.Network network = new Model.Network(Model.NetworkMode.Run);
            Presenter presenter = new Presenter(network, _form1View);

            Application.Run(_form1View);
        }
    }
}
