namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Events
{
    public abstract class AbstractClassWithNestedStructWithEventWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
