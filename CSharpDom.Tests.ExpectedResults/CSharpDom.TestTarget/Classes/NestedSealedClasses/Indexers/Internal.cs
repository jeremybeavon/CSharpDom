namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers
{
    public class ClassWithNestedSealedClassWithInternalIndexer
    {
        public sealed class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
