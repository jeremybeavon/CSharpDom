namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.OperatorOverloads
{
    public abstract class AbstractClassWithNestedStructWithOrOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator |(Struct parameter1, Struct parameter2)
            {
                return default(Struct);
            }
        }
    }
}
