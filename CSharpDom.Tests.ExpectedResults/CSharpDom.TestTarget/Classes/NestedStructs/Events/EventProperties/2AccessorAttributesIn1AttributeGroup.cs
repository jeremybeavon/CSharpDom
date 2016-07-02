namespace CSharpDom.TestTarget.Classes.NestedStructs.Events.EventProperties
{
    public class ClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
    {
        public struct Struct
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
