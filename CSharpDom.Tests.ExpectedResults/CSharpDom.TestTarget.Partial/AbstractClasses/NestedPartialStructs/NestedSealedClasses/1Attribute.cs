namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedSealedPartialClassWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public sealed class NestedClass
            {
            }
        }
    }
}
