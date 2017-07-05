namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Constructors
{
    public abstract class AbstractClassWithNestedPartialClassWithConstructorWithParametersWithAttributes
    {
        public partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
