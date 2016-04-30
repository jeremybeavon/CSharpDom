namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events
{
    public struct StructWithNestedSealedClassWithInternalEvent
    {
        public sealed class Class
        {
            internal event EventHandler Event;
        }
    }
}
