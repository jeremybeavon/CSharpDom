namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Events
{
    public abstract class AbstractClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
