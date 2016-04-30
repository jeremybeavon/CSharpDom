namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithPrivateEventProperty
    {
        public abstract class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
