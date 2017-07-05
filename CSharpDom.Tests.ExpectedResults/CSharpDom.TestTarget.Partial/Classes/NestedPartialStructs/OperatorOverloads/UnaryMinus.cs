namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.OperatorOverloads
{
    public class ClassWithNestedStructWithUnaryMinusOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator -(Struct parameter1)
            {
                return default(Struct);
            }
        }
    }
}
