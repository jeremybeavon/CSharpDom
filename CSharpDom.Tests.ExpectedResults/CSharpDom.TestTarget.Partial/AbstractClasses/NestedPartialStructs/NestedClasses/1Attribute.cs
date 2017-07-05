namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedPartialClassWith1Attribute
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
