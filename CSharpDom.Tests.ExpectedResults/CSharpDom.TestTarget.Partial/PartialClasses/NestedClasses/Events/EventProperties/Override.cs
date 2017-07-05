namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedClassWithOverrideEventProperty
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
