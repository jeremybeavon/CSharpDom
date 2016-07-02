namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            public event EventHandler Event
            {
                [Attribute1, Attribute2]
                add { }
                [Attribute1, Attribute2]
                remove { }
            }
        }
    }
}
