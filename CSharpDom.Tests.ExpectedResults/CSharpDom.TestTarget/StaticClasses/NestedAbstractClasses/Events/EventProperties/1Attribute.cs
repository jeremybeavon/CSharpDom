namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractClassWithEventPropertyWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
