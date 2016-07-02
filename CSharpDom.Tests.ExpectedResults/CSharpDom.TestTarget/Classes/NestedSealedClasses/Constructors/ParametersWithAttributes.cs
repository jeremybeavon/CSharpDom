namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Constructors
{
    public class ClassWithNestedSealedClassWithConstructorWithParametersWithAttributes
    {
        public sealed class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
