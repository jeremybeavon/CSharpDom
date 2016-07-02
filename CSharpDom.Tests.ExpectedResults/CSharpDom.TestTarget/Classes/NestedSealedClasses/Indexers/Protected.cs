namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers
{
    public class ClassWithNestedSealedClassWithProtectedIndexer
    {
        public sealed class Class
        {
            protected string this[int index]
            {
                set { }
            }
        }
    }
}
