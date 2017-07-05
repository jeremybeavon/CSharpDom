namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedSealedClasses
{
    public class ClassWithNestedStructWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
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
