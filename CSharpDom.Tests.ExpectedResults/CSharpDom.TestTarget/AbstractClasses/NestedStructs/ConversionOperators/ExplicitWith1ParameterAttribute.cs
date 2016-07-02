namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.ConversionOperators
{
    public abstract class AbstractClassWithNestedStructWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public struct Struct
        {
            public static explicit operator Struct([Attribute1]string text)
            {
                return default(Struct);
            }
        }
    }
}
