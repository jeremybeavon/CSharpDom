namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Methods
{
    public abstract partial class AbstractPartialClassWithNestedStructWithMethodWithParametersWithAttributes
    {
        public struct Struct
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
