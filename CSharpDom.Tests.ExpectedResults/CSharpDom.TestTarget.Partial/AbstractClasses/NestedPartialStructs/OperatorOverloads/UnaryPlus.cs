namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.OperatorOverloads
{
    public abstract class AbstractClassWithNestedStructWithUnaryPlusOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator +(Struct parameter1)
            {
                return default(Struct);
            }
        }
    }
}
