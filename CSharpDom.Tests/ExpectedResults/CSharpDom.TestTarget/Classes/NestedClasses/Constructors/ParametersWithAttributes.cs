namespace CSharpDom.TestTarget.Classes.NestedClasses.Constructors
{
    public class ClassWithNestedClassWithConstructorWithParametersWithAttributes
    {
        public class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
