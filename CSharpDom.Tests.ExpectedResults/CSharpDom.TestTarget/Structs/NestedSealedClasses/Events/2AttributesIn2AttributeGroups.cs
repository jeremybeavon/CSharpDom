namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Constructors
{
    public struct StructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
