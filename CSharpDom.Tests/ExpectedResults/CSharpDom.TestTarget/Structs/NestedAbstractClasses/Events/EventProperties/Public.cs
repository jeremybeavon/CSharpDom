namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.EventProperties
{
    public struct StructWithNestedAbstractClassWithPublicEventProperty
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
