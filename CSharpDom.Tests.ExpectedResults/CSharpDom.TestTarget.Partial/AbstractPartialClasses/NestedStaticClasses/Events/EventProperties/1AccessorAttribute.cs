namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute
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
