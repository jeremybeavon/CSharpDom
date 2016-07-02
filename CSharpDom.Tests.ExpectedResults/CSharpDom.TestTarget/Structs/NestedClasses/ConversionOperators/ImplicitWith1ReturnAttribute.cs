namespace CSharpDom.TestTarget.Structs.NestedClasses.ConversionOperators
{
    public struct StructWithNestedClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        public class Class
        {
            [return: Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
