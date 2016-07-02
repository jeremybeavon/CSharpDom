namespace CSharpDom.TestTarget.AbstractClasses.Indexers
{
    public abstract class AbstractClassWithIndexerWith1Attribute
    {
        [Attribute1]
        public string this[int index]
        {
            set { }
        }
    }
}
