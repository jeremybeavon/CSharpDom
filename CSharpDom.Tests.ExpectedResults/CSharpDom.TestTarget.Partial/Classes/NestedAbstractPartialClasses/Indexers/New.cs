namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Indexers
{
    public class ClassWithNestedAbstractPartialClassWithNewIndexer
    {
        public abstract class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
