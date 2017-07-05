namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedStaticClassWithEventPropertyWith1Attribute
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
