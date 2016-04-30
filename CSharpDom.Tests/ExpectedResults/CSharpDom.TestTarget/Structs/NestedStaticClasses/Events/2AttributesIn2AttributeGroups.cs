namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Constructors
{
    public struct StructWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups
    {
        public static class Class
        {
            [Attribute1]
            [Attribute2]
            public static event EventHandler Event;
        }
    }
}
