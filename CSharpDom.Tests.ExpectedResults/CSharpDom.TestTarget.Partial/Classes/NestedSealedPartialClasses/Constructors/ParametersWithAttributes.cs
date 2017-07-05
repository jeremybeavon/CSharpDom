namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Constructors
{
    public class ClassWithNestedSealedPartialClassWithConstructorWithParametersWithAttributes
    {
        public sealed partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
