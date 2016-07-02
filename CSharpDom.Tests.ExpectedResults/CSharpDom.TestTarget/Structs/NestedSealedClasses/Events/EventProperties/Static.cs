namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.EventProperties
{
    public struct StructWithNestedSealedClassWithStaticEventProperty
    {
        public sealed class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
