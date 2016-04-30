namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedSealedClassWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
