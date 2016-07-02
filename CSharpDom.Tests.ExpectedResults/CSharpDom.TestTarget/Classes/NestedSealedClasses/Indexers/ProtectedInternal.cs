namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers
{
    public class ClassWithNestedSealedClassWithProtectedInternalIndexer
    {
        public sealed class Class
        {
            protected internal string this[int index]
            {
                set { }
            }
        }
    }
}
