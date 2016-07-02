namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers
{
    public sealed class SealedClassWithNestedClassWithPrivateIndexer
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
