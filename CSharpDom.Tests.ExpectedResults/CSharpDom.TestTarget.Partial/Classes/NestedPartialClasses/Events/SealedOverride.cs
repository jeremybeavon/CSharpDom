namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events
{
    public class ClassWithNestedPartialClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
