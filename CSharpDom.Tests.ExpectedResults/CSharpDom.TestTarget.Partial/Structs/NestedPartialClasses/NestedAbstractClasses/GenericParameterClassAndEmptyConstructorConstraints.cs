namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
