namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithPrivateEventProperty
    {
        public static partial class Class
        {
            private static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
