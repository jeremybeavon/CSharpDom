namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedStaticClassWith1Attribute
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
