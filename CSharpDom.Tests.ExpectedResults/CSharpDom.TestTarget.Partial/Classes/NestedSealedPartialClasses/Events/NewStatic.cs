namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events
{
    public class ClassWithNestedSealedPartialClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
