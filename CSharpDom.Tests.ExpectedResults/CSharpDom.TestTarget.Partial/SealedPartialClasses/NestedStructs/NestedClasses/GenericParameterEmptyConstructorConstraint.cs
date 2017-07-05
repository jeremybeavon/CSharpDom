namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
