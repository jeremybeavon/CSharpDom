namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers
{
    public sealed class SealedClassWithNestedClassWithOverrideIndexer
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
