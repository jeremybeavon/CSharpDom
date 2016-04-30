namespace CSharpDom.TestTarget.Structs.NestedClasses.Events
{
    public struct StructWithNestedClassWithEventWith2AttributesIn2AttributeGroups
    {
        public class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
