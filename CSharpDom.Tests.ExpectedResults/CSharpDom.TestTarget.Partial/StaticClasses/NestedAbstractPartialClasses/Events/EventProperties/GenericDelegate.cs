namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractPartialClassWithEventPropertyWithGenericDelegate
    {
        public abstract partial class Class
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
