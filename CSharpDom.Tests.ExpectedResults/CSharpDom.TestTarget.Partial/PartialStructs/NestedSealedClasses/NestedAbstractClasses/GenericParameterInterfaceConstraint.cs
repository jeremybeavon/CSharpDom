namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
