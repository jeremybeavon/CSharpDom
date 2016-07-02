namespace CSharpDom.TestTarget.Classes.NestedStructs.Constructors
{
    public class ClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
