namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
