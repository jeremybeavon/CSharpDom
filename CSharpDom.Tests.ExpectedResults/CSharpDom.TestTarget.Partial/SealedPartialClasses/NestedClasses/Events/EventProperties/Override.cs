namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedClassWithOverrideEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
