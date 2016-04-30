namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedAbstractClassWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public abstract class NestedClass
            {
            }
        }
    }
}
