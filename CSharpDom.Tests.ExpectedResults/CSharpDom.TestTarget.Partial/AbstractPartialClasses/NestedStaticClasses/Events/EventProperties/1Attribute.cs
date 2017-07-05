namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithEventPropertyWith1Attribute
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
