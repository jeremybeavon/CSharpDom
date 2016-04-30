namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Constructors
{
    public abstract class AbstractClassWithNestedClassWithConstructorWithParametersWithAttributes
    {
        public class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
