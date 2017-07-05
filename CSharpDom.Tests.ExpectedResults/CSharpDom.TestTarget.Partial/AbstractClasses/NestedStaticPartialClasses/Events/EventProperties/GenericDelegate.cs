namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithEventPropertyWithGenericDelegate
    {
        public static partial class Class
        {
            public static event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
