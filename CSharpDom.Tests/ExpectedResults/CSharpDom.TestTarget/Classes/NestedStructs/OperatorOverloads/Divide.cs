namespace CSharpDom.TestTarget.Classes.NestedStructs.OperatorOverloads
{
    public class ClassWithNestedStructWithDivideOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator /(Struct parameter1, Struct parameter2)
            {
                return default(Struct);
            }
        }
    }
}
