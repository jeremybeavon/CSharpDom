namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers
{
    public abstract class AbstractClassWithNestedClassWithOverrideIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public override string this[int index]
            {
                set { }
            }
        }
    }
}
