namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
