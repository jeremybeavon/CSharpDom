namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedClassWithOverrideEventProperty
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
