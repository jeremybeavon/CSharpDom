namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
