namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute
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
