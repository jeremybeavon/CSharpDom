namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers
{
    public sealed class SealedClassWithNestedClassWithProtectedIndexer
    {
        public class Class
        {
            protected string this[int index]
            {
                set { }
            }
        }
    }
}
