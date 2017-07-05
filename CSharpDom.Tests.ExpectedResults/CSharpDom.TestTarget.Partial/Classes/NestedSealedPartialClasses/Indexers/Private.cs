namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Indexers
{
    public class ClassWithNestedSealedPartialClassWithPrivateIndexer
    {
        public sealed partial class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
