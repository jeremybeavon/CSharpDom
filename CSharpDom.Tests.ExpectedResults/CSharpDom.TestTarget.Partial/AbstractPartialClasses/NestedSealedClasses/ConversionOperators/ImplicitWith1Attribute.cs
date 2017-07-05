namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithImplicitConversionOperatorWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
