using System;

namespace NeuralNetworks
{
    public interface IView
    {
        double[] InputPixels{ get; }
        double[] NetOutput { set; }
        event EventHandler<EventArgs> GotResult;
    }
}
