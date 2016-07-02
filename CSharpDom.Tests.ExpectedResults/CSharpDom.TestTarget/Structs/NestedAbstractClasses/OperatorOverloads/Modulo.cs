namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.OperatorOverloads
{
    public struct StructWithNestedAbstractClassWithModuloOperatorOverload
    {
        public abstract class Class
        {
            public static Class operator %(Class parameter1, Class parameter2)
            {
                return default(Class);
            }
        }
    }
}
