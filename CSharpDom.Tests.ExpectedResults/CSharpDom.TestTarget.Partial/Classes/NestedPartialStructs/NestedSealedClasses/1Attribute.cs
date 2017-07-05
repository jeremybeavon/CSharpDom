namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedSealedClasses
{
    public class ClassWithNestedStructWithNestedSealedPartialClassWith1Attribute
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
