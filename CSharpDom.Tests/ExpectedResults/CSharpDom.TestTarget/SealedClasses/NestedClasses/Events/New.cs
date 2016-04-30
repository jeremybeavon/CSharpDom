namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events
{
    public sealed class SealedClassWithNestedClassWithNewEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
