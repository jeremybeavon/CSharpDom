namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedSealedClassWith1Attribute
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
