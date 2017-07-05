namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.ConversionOperators
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithImplicitConversionOperatorWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
