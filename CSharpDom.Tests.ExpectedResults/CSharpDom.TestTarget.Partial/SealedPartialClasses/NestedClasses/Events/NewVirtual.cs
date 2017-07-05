namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedClassWithNewVirtualEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
