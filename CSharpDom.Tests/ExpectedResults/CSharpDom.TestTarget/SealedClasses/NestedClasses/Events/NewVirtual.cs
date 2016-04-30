namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events
{
    public sealed class SealedClassWithNestedClassWithNewVirtualEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
