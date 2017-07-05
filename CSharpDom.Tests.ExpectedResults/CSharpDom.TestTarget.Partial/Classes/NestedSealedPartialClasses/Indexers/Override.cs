namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Indexers
{
    public class ClassWithNestedSealedPartialClassWithOverrideIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public override string this[int index]
            {
                set { }
            }
        }
    }
}
