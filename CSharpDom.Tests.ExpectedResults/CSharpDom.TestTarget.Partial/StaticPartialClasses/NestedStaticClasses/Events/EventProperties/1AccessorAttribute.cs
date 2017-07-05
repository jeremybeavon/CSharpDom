namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute
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
