namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedAbstractPartialClassWith1Attribute
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
