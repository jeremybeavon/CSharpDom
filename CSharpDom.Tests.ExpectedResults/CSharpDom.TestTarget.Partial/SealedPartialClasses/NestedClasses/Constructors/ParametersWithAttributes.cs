namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Constructors
{
    public sealed partial class SealedPartialClassWithNestedClassWithConstructorWithParametersWithAttributes
    {
        public class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
