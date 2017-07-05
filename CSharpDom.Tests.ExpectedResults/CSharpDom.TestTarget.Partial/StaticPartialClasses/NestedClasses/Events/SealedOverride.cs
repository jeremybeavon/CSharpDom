namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Events
{
    public static partial class StaticPartialClassWithNestedClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
