namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events
{
    public struct StructWithNestedSealedClassWithProtectedEvent
    {
        public sealed class Class
        {
            protected event EventHandler Event;
        }
    }
}
