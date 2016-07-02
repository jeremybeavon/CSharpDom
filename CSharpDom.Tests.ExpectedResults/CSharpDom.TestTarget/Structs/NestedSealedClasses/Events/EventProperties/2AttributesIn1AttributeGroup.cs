namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.EventProperties
{
    public struct StructWithNestedSealedClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
