namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
