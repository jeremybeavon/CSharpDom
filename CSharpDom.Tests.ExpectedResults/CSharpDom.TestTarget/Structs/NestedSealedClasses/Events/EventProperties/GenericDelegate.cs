namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.EventProperties
{
    public struct StructWithNestedSealedClassWithEventPropertyWithGenericDelegate
    {
        public sealed class Class
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
