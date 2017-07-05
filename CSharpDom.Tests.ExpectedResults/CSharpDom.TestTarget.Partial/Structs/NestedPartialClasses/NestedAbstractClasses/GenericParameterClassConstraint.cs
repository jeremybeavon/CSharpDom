namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
