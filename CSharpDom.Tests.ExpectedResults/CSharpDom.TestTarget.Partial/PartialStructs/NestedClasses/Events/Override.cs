namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events
{
    public partial struct PartialStructWithWithNestedClassWithOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
