namespace CSharpDom.TestTarget.Structs.Events.EventProperties
{
    public struct StructWithPrivateEventProperty
    {
        private event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
