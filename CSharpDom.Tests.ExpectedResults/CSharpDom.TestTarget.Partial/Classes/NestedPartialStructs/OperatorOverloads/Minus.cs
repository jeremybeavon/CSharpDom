namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.OperatorOverloads
{
    public class ClassWithNestedStructWithMinusOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator -(Struct parameter1, Struct parameter2)
            {
                return default(Struct);
            }
        }
    }
}
