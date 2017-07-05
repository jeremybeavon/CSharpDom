namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithEventPropertyWith1Attribute
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
