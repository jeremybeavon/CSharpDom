namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
