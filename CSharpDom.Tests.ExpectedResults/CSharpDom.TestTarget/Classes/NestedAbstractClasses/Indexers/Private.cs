namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Indexers
{
    public class ClassWithNestedAbstractClassWithPrivateIndexer
    {
        public abstract class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
