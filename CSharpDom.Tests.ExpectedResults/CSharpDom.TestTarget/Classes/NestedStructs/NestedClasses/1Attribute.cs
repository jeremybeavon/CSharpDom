namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedClasses
{
    public class ClassWithNestedStructWithNestedClassWith1Attribute
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
