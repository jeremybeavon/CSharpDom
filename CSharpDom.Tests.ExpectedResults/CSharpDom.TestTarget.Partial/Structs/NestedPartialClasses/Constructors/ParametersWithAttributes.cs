namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Constructors
{
    public struct StructWithNestedPartialClassWithConstructorWithParametersWithAttributes
    {
        public partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
