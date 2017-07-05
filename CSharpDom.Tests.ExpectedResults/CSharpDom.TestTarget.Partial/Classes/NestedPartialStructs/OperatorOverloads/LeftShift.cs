namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.OperatorOverloads
{
    public class ClassWithNestedStructWithLeftShiftOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator <<(Struct parameter1, int parameter2)
            {
                return default(Struct);
            }
        }
    }
}
