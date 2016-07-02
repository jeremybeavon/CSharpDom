namespace CSharpDom.TestTarget.AbstractClasses.Constructors
{
    public abstract class AbstractClassWithConstructorWithParametersWithAttributes
    {
        public AbstractClassWithConstructorWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
        {
        }
    }
}
