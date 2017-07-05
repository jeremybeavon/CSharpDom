namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedSealedClasses
{
    public class ClassWithNestedStructWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
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
