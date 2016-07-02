namespace CSharpDom.TestTarget.Classes.NestedStructs.OperatorOverloads
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
