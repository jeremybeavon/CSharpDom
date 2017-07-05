namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithVirtualEventProperty
    {
        public abstract partial class Class
        {
            public virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
