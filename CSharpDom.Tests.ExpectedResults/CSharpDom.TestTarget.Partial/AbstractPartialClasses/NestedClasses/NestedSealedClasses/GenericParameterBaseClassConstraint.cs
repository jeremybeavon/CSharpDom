namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedSealedClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
