namespace CSharpDom.TestTarget.Partial.Structs.NestedClasses
{
    public struct StructWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public class Class<T>
            where T : class
        {
        }
    }
}
