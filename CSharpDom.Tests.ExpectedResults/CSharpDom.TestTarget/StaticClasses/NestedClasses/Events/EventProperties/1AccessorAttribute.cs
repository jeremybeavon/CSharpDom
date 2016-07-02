namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedClassWithEventPropertyWith1AccessorAttribute
    {
        public class Class
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
