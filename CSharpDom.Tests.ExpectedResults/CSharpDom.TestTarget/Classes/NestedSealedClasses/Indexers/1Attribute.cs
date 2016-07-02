namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers
{
    public class ClassWithNestedSealedClassWithIndexerWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
