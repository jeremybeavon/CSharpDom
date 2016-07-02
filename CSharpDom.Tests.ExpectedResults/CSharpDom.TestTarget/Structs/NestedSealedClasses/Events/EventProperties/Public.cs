namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.EventProperties
{
    public struct StructWithNestedSealedClassWithPublicEventProperty
    {
        public sealed class Class
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
