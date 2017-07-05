namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
