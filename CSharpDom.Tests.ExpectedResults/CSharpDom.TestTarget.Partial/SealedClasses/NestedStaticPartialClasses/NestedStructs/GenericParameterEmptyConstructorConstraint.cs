namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
