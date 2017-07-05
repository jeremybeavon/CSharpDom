namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Indexers
{
    public partial class PartialClassWithNestedClassWithOverrideIndexer
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
