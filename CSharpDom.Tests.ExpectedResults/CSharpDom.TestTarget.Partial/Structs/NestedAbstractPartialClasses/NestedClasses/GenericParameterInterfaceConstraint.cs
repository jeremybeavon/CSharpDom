namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
