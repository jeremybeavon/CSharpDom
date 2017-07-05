namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
