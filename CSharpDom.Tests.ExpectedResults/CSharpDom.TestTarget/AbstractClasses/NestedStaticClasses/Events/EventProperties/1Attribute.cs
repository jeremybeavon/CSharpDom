namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStaticClassWithEventPropertyWith1Attribute
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
