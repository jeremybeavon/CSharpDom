namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Methods
{
    public partial struct PartialStructWithWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
