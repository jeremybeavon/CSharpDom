namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Events.EventProperties
{
    public class ClassWithNestedStaticClassWithEventPropertyWith1Attribute
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
