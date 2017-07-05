namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.OperatorOverloads
{
    public abstract class AbstractClassWithNestedStructWithUnaryMinusOperatorOverload
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
