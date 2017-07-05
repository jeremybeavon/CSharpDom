namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedAbstractClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
