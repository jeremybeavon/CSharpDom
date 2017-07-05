namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events
{
    public partial struct PartialStructWithWithNestedClassWithNewEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
