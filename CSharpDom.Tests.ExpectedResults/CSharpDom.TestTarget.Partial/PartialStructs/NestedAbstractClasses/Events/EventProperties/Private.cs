namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.EventProperties
{
    public partial struct PartialStructWithNestedAbstractClassWithPrivateEventProperty
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
