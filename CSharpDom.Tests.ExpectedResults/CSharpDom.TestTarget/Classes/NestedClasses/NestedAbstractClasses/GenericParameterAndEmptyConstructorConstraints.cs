namespace CSharpDom.TestTarget.Classes.NestedClasses.NestedAbstractClasses
{
    public class ClassWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
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
