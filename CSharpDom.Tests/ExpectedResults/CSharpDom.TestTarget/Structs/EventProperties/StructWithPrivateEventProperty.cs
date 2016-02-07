namespace CSharpDom.TestTarget.Structs.EventProperties
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
