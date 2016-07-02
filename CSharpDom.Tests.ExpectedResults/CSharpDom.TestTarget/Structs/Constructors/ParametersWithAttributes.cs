namespace CSharpDom.TestTarget.Structs.Constructors
{
    public struct StructWithConstructorWithParametersWithAttributes
    {
        public StructWithConstructorWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
        {
        }
    }
}
