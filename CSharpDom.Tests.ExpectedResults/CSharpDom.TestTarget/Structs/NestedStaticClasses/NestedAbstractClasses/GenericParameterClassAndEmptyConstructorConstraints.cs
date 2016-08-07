namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedAbstractClasses
{
    public struct StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
