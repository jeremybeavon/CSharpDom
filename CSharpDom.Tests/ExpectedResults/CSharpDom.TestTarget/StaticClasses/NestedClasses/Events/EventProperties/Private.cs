namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedClassWithPrivateEventProperty
    {
        public class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
