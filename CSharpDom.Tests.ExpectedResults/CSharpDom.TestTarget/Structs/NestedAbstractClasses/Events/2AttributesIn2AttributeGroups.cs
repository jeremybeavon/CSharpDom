namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events
{
    public struct StructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
