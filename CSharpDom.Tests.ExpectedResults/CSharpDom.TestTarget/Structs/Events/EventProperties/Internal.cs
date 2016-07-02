namespace CSharpDom.TestTarget.Structs.EventProperties
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
