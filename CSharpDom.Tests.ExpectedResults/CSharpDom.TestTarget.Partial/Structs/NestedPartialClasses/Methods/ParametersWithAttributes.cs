namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Methods
{
    public struct StructWithNestedPartialClassWithMethodWithParametersWithAttributes
    {
        public partial class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
