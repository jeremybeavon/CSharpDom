namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedClassWithNewStaticEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
