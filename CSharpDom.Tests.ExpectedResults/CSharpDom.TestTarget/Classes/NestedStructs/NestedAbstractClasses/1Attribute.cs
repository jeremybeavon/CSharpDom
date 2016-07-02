namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedAbstractClasses
{
    public class ClassWithNestedStructWithNestedAbstractClassWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public abstract class NestedClass
            {
            }
        }
    }
}
