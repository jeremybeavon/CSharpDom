namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events
{
    public class ClassWithNestedSealedPartialClassWithOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
