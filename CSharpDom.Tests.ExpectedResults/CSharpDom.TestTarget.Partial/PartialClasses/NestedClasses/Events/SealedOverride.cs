namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Events
{
    public partial class PartialClassWithNestedClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
