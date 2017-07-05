namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Methods
{
    public struct StructWithNestedSealedPartialClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
