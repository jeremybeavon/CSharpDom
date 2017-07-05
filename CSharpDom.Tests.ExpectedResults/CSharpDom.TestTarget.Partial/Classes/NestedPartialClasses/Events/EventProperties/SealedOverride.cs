namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events.EventProperties
{
    public class ClassWithNestedPartialClassWithSealedOverrideEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
