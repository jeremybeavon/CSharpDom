namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
