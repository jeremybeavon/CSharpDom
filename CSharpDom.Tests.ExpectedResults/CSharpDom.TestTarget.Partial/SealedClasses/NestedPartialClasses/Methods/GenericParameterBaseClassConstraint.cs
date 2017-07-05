namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Methods
{
    public sealed class SealedClassWithNestedPartialClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
