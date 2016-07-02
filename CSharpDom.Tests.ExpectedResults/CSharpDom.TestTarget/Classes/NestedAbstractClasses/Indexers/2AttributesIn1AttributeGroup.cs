namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Indexers
{
    public class ClassWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
