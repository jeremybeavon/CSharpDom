namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Constructors
{
    public abstract class AbstractClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes
    {
        public abstract class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
