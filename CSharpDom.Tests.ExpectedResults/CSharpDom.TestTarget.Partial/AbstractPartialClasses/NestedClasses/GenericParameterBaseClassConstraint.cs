namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public class Class<T>
            where T : BaseClass
        {
        }
    }
}
