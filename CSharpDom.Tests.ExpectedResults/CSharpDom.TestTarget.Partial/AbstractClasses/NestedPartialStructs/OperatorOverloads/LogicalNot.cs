namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.OperatorOverloads
{
    public abstract class AbstractClassWithNestedStructWithLogicalNotOperatorOverload
    {
        public struct Struct
        {
            public static bool operator !(Struct parameter1)
            {
                return default(bool);
            }
        }
    }
}
