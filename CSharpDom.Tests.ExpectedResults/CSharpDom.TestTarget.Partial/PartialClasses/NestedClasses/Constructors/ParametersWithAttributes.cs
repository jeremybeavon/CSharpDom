namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Constructors
{
    public partial class PartialClassWithNestedClassWithConstructorWithParametersWithAttributes
    {
        public class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
