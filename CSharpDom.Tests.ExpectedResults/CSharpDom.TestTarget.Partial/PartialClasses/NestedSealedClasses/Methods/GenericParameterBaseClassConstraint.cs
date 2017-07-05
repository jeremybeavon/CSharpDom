namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Methods
{
    public partial class PartialClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
