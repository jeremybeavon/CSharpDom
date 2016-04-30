namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedClassWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public class NestedClass
            {
            }
        }
    }
}
