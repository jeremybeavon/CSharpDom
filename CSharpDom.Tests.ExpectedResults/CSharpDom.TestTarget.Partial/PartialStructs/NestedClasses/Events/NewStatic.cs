namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events
{
    public partial struct PartialStructWithWithNestedClassWithNewStaticEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
