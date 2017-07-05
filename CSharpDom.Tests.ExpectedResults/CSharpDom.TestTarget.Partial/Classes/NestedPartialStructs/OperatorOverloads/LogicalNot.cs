namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.OperatorOverloads
{
    public class ClassWithNestedStructWithLogicalNotOperatorOverload
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
