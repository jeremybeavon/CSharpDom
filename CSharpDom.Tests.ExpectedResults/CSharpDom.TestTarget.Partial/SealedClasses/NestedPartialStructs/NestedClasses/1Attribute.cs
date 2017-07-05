namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedPartialClassWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public class NestedClass
            {
            }
        }
    }
}
