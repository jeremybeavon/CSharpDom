namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiers
    {
        public sealed class Class
        {
            public string this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
