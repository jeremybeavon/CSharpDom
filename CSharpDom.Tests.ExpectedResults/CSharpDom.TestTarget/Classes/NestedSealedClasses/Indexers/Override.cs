namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers
{
    public class ClassWithNestedSealedClassWithOverrideIndexer
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
