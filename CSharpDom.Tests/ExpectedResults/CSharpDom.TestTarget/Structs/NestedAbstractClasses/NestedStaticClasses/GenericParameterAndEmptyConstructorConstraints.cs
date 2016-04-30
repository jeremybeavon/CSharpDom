namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedStaticClasses
{
    public struct StructWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
