namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Events.EventProperties
{
    public class ClassWithNestedStaticClassWithEventPropertyWithGenericDelegate
    {
        public static class Class
        {
            public static event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
