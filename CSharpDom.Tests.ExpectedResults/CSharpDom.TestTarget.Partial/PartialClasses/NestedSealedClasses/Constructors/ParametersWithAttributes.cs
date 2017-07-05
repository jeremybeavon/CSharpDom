namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Constructors
{
    public partial class PartialClassWithNestedSealedClassWithConstructorWithParametersWithAttributes
    {
        public sealed class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
