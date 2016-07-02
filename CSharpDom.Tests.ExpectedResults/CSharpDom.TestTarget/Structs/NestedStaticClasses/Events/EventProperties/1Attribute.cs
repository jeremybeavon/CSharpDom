namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Events.EventProperties
{
    public struct StructWithNestedStaticClassWithEventPropertyWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
