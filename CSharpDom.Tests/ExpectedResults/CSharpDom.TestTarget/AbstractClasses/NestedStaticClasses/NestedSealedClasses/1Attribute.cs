namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedSealedClassWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
