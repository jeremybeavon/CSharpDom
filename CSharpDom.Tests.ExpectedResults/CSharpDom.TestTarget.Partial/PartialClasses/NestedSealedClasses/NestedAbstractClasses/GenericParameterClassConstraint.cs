namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
