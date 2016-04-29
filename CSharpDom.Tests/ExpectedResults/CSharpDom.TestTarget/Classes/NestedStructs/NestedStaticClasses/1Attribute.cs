namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedStaticClasses
{
    public class ClassWithNestedStructWithNestedStaticClassWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public static class NestedClass
            {
            }
        }
    }
}
