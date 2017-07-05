namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.OperatorOverloads
{
    public abstract class AbstractClassWithNestedStructWithEqualAndNotEqualOperatorOverloads
    {
        public struct Struct
        {
            public static bool operator ==(Struct parameter1, Struct parameter2)
            {
                return default(bool);
            }

            public static bool operator !=(Struct parameter1, Struct parameter2)
            {
                return default(bool);
            }
        }
    }
}
