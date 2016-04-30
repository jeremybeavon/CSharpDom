namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers
{
    public sealed class SealedClassWithNestedClassWithInternalIndexer
    {
        public class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
