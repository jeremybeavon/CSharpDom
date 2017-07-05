namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedSealedClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
