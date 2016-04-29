namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStaticClasses
{
    public class ClassWithNestedSealedClassWithNestedStaticClassWith1Attribute
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
