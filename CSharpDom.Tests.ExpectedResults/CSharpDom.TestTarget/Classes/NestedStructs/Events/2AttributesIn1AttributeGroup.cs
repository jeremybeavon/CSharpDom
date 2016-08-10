namespace CSharpDom.TestTarget.Classes.NestedStructs.Events
{
    public class ClassWithNestedStructsWithEventWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
