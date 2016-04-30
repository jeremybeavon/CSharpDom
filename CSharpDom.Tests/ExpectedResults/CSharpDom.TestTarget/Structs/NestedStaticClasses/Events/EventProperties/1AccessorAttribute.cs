namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Events.EventProperties
{
    public struct StructWithNestedStaticClassWithEventPropertyWith1AccessorAttribute
    {
        public static class Class
        {
            public static event EventHandler Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
