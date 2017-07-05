namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Constructors
{
    public partial struct PartialStructWithWithNestedClassWithConstructorWithParametersWithAttributes
    {
        public class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
