namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithInternalEventProperty
    {
        public static partial class Class
        {
            internal static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
