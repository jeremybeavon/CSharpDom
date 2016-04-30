namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedClassWithProtectedEventProperty
    {
        public class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
