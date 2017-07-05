namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events
{
    public sealed class SealedClassWithNestedPartialClassWithNewVirtualEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
