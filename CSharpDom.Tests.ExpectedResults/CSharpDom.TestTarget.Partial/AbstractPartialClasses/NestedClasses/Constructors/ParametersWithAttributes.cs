namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Constructors
{
    public abstract partial class AbstractPartialClassWithNestedClassWithConstructorWithParametersWithAttributes
    {
        public class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
