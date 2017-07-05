namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Constructors
{
    public struct StructWithNestedAbstractPartialClassWithConstructorWithParametersWithAttributes
    {
        public abstract partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
