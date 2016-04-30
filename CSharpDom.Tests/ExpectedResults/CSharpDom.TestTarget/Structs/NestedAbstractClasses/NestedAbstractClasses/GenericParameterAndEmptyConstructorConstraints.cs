namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedAbstractClasses
{
    public struct StructWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
