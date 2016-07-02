namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Methods
{
    public abstract class AbstractClassWithNestedStructWithMethodWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public void Method()
            {
            }
        }
    }
}
