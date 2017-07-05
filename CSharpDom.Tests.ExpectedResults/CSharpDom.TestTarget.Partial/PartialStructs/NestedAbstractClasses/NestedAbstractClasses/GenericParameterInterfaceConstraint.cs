namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
