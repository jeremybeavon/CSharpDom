namespace CSharpDom.TestTarget.Structs.NestedClasses.Events
{
    public struct StructWithNestedClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
