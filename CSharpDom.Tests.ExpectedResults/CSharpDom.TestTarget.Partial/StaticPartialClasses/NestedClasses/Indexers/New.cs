namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Indexers
{
    public static partial class StaticPartialClassWithNestedClassWithNewIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
