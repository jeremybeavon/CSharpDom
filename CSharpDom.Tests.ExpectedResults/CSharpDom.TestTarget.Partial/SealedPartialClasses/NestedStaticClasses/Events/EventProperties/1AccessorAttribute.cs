namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute
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
