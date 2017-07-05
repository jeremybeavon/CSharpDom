namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events
{
    public class ClassWithNestedSealedPartialClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
