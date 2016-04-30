namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedSealedClassWith1Attribute
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
