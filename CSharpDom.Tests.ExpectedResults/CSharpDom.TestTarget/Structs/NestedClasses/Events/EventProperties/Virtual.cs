namespace CSharpDom.TestTarget.Structs.NestedClasses.Events.EventProperties
{
    public struct StructWithNestedClassWithVirtualEventProperty
    {
        public class Class
        {
            public virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
