namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
