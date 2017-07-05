namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedPartialClassWith1Attribute
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
