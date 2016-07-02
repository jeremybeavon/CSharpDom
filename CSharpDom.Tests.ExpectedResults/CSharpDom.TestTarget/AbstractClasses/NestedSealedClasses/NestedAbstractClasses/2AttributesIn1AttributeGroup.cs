namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public abstract class NestedClass
            {
            }
        }
    }
}
