namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Constructors
{
    public abstract class AbstractClassWithNestedSealedClassWithConstructorWithParametersWithAttributes
    {
        public sealed class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
