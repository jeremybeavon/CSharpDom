namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events
{
    public class ClassWithNestedSealedClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
