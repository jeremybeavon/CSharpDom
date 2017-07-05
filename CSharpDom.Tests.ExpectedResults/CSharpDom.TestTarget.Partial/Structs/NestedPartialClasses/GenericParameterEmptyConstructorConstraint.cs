namespace CSharpDom.TestTarget.Partial.Structs.NestedClasses
{
    public struct StructWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class<T>
            where T : new()
        {
        }
    }
}
