namespace CSharpDom.TestTarget
{
    public delegate void EventHandler<TEventArgs>(object sender, TEventArgs args)
        where TEventArgs : EventArgs;
}
