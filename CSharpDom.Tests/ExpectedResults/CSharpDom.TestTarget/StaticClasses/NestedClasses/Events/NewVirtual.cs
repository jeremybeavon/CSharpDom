namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events
{
    public static class StaticClassWithNestedClassWithNewVirtualEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
