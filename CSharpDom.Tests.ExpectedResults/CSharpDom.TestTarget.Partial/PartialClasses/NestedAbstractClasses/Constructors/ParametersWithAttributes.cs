namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Constructors
{
    public partial class PartialClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes
    {
        public abstract class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
