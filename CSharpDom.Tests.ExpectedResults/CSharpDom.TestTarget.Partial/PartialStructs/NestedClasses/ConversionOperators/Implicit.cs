namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.ConversionOperators
{
    public partial struct PartialStructWithWithNestedClassWithImplicitConversionOperator
    {
        public class Class
        {
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
