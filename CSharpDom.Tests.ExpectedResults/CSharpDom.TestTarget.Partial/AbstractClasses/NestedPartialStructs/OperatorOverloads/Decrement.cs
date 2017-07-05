namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.OperatorOverloads
{
    public abstract class AbstractClassWithNestedStructWithDecrementOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator --(Struct parameter1)
            {
                return default(Struct);
            }
        }
    }
}
