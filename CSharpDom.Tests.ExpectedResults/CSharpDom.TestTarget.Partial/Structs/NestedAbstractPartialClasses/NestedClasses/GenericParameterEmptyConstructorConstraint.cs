namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
