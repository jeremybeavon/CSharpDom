namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Indexers
{
    public partial struct PartialStructWithNestedClassWithPrivateIndexer
    {
        public class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
