namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
