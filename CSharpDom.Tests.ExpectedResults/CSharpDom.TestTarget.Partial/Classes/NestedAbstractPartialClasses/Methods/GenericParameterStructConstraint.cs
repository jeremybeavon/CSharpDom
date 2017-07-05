namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Methods
{
    public class ClassWithNestedAbstractPartialClassWithMethodWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
