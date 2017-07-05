namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
