namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Events
{
    public struct StructWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
