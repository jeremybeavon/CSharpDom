namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Constructors
{
    public static partial class StaticPartialClassWithNestedSealedClassWithConstructorWithParametersWithAttributes
    {
        public sealed class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
