namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events
{
    public static class StaticClassWithNestedPartialClassWithNewVirtualEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
