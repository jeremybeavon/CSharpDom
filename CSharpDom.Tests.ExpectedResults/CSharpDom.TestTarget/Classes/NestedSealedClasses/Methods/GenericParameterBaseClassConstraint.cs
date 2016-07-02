namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods
{
    public class ClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
