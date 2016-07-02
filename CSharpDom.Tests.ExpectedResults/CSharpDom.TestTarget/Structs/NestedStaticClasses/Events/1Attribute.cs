namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Events
{
    public struct StructWithNestedStaticClassWithEventWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public static event EventHandler Event;
        }
    }
}
