namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events
{
    public partial struct PartialStructWithWithNestedClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
