namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Constructors
{
    public sealed class SealedClassWithNestedClassWithConstructorWithParametersWithAttributes
    {
        public class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
