namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithOverrideEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
