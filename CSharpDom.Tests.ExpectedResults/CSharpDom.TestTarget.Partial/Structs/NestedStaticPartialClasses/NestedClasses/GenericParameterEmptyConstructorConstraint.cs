namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
