namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Methods
{
    public struct StructWithNestedSealedPartialClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
