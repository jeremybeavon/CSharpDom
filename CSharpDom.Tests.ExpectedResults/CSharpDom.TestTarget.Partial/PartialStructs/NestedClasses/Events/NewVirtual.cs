namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events
{
    public partial struct PartialStructWithWithNestedClassWithNewVirtualEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
