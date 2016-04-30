namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events
{
    public static class StaticClassWithNestedClassWithNewStaticEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
