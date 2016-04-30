namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Methods
{
    public abstract class AbstractClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
