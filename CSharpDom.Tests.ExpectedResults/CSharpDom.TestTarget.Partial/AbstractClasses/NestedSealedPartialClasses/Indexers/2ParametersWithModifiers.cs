namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithIndexerWith2ParametersWithModifiers
    {
        public sealed partial class Class
        {
            public string this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
