namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Constructors
{
    public sealed class SealedClassWithNestedPartialClassWithConstructorWithParametersWithAttributes
    {
        public partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
