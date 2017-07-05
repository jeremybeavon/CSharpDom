namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Methods
{
    public partial class PartialClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint
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
