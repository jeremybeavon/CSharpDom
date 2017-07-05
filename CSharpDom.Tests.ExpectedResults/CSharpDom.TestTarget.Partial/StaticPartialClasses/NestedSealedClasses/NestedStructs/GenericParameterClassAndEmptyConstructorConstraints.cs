namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
