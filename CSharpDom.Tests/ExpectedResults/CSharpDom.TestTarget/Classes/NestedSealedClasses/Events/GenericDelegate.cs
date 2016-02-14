namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events
{
    public class ClassWithNestedSealedClassWithEventWithGenericDelegate
    {
        public sealed class Class
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
