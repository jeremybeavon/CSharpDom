namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedAbstractClassWith1Attribute
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
