namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedClassWithVirtualEventProperty
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
