namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
