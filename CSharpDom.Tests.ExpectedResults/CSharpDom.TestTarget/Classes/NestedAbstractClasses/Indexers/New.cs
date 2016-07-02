namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Indexers
{
    public class ClassWithNestedAbstractClassWithNewIndexer
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
