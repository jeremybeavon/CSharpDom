namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
