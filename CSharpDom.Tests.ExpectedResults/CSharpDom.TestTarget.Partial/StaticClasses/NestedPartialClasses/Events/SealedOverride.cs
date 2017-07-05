namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events
{
    public static class StaticClassWithNestedPartialClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
