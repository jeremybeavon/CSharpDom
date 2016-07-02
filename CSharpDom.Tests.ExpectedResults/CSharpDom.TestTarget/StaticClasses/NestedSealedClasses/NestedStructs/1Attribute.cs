namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedStructs
{
    public static class StaticClassWithNestedSealedClassWithNestedStructWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
