namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedStaticClassWithEventPropertyWith1AccessorAttribute
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
