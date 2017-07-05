namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractPartialClassWithEventPropertyWith1AccessorAttribute
    {
        public abstract partial class Class
        {
            public event EventHandler Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
