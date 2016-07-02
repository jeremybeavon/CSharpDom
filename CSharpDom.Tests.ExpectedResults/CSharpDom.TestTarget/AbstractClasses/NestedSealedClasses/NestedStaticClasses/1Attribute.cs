namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedStaticClassWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public static class NestedClass
            {
            }
        }
    }
}
