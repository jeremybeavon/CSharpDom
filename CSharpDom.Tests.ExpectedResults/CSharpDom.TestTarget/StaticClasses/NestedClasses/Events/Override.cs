namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events
{
    public static class StaticClassWithNestedClassWithOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
