namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithPrivateEventProperty
    {
        public abstract partial class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
