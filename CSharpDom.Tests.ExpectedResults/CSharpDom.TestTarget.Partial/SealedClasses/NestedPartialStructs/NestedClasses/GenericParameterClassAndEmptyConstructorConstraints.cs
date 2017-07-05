namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
