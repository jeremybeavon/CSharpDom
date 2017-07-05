namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithGenericParameterClassConstraint
    {
        public class Class<T>
            where T : class
        {
        }
    }
}
