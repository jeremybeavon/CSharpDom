namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStructWithNestedAbstractPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
