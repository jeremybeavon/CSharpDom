namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStaticClassWithEventPropertyWithGenericDelegate
    {
        public static class Class
        {
            public static event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
