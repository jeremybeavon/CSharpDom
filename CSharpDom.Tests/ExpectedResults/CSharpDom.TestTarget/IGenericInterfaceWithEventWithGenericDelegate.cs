namespace CSharpDom.TestTarget
{
    public interface IGenericInterfaceWithEventWithGenericDelegate<TEventArgs>
        where TEventArgs : EventArgs
    {
        event EventHandler<TEventArgs> Event;
    }
}
