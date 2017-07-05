namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Methods
{
    public partial class PartialClassWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
