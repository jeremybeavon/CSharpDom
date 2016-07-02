namespace CSharpDom.TestTarget.Structs.NestedClasses.OperatorOverloads
{
    public struct StructWithNestedClassWithIncrementOperatorOverload
    {
        public class Class
        {
            public static Class operator ++(Class parameter1)
            {
                return default(Class);
            }
        }
    }
}
