namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Methods
{
    public abstract class AbstractClassWithNestedStructWithMethodWith1ReturnAttribute
    {
        public struct Struct
        {
            [return: Attribute1]
            public void Method()
            {
            }
        }
    }
}
