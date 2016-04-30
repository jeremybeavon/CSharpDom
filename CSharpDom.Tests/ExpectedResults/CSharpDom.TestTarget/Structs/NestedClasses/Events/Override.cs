namespace CSharpDom.TestTarget.Structs.NestedClasses.Events
{
    public struct StructWithNestedClassWithOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
