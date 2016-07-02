namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedClassWithIndexerWith2ParametersWithParameters
    {
        public sealed class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
