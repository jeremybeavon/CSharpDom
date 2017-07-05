namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedClassWithNewEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public new event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
