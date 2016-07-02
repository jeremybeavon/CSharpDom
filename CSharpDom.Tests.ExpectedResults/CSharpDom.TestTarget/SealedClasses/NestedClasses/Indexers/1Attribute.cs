namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers
{
    public sealed class SealedClassWithNestedClassWithIndexerWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
