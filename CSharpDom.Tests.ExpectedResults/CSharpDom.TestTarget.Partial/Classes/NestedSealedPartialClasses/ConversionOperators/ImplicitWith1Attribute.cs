namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.ConversionOperators
{
    public class ClassWithNestedSealedPartialClassWithImplicitConversionOperatorWith1Attribute
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
