namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithSealedOverrideEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
