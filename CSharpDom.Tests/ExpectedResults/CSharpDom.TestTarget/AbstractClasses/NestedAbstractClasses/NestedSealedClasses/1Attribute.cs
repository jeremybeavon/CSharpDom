namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedSealedClassWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
