namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events
{
    public sealed class SealedClassWithNestedClassWithNewStaticEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
