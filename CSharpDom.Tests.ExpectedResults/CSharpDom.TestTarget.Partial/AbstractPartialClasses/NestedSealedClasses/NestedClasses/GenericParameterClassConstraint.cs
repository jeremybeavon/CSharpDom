namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
