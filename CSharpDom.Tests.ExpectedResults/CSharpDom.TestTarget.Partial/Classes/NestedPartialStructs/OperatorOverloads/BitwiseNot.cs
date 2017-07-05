namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.OperatorOverloads
{
    public class ClassWithNestedStructWithBitwiseNotOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator ~(Struct parameter1)
            {
                return default(Struct);
            }
        }
    }
}
