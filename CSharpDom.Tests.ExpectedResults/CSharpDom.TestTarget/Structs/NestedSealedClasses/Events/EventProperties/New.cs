namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.EventProperties
{
    public struct StructWithNestedSealedClassWithNewEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
