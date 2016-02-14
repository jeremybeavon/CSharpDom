namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers
{
    public class ClassWithNestedSealedClassWithPublicIndexer
    {
        public sealed class Class
        {
            public string this[int index]
            {
                set { }
            }
        }
    }
}
