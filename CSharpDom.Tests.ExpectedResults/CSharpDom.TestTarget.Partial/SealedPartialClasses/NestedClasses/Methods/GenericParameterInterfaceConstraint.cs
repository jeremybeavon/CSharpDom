namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
