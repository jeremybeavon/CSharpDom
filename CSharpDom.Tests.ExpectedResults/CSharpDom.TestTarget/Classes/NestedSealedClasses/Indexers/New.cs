namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers
{
    public class ClassWithNestedSealedClassWithNewIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
