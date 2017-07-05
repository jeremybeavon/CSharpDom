namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute
    {
        public abstract class Class
        {
            public event EventHandler Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
