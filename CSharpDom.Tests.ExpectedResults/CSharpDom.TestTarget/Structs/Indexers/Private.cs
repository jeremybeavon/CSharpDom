namespace CSharpDom.TestTarget.Structs
{
    public struct StructWithPrivateIndexer
    {
        private string this[int index]
        {
            set { }
        }
    }
}
