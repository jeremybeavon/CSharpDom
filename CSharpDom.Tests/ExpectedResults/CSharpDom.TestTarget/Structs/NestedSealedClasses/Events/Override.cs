namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events
{
    public struct StructWithNestedSealedClassWithOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
