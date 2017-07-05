namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithInternalEventProperty
    {
        public abstract partial class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
