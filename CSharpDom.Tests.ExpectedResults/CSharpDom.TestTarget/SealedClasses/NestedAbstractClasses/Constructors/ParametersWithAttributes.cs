namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Constructors
{
    public sealed class SealedClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes
    {
        public abstract class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
