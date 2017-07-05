namespace CSharpDom.TestTarget.Partial.Structs.NestedClasses
{
    public struct StructWithNestedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class<T>
            where T : class, new()
        {
        }
    }
}
