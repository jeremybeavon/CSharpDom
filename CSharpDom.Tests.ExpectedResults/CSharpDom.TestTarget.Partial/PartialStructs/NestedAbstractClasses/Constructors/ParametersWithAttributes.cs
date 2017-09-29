namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Constructors
{
    public partial struct PartialStructWithNestedAbstractClassWithConstructorWithParametersWithAttributes
    {
        public abstract class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
