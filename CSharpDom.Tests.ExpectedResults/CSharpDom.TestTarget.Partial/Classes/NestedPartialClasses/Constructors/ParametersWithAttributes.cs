namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Constructors
{
    public class ClassWithNestedPartialClassWithConstructorWithParametersWithAttributes
    {
        public partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
