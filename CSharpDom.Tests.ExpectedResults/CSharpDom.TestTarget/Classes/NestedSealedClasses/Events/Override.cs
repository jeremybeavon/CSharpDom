namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events
{
    public class ClassWithNestedSealedClassWithOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
