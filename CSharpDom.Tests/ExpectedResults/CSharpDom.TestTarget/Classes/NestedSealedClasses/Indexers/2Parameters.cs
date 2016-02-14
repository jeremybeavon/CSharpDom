namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers
{
    public class ClassWithNestedSealedClassWithIndexerWith2Parameters
    {
        public sealed class Class
        {
            public string this[int x, int y]
            {
                set { }
            }
        }
    }
}
