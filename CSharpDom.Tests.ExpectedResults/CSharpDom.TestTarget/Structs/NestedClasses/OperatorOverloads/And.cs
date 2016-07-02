namespace CSharpDom.TestTarget.Structs.NestedClasses.OperatorOverloads
{
    public struct StructWithNestedClassWithAndOperatorOverload
    {
        public class Class
        {
            public static Class operator &(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
