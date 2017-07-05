namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Constructors
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithConstructorWithParametersWithAttributes
    {
        public abstract partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
