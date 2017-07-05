namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedClassWithSealedOverrideEventProperty
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
