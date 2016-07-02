namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events
{
    public class ClassWithNestedSealedClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
