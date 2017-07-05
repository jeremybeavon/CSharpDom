namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedStaticPartialClassWithEventPropertyWith1Attribute
    {
        public static partial class Class
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
