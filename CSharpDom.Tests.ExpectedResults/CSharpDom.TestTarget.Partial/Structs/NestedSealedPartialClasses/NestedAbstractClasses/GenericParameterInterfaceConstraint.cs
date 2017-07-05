namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
