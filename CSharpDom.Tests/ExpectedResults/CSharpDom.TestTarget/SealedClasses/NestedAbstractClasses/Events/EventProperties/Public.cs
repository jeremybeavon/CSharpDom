namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithPublicEventProperty
    {
        public abstract class Class
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
