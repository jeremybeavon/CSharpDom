namespace CSharpDom.TestTarget.Structs.Events.EventProperties
{
    public struct StructWithInternalEventProperty
    {
        internal event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
