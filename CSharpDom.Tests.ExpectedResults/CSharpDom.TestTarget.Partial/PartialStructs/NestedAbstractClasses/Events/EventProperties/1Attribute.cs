namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedAbstractClassWithEventPropertyWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
