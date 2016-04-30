namespace CSharpDom.TestTarget.Structs.NestedClasses.Events
{
    public struct StructWithNestedClassWithNewVirtualEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
