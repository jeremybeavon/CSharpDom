namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Methods
{
    public abstract partial class AbstractPartialClassWithNestedStructWithMethodWith1ReturnAttribute
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
