namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
