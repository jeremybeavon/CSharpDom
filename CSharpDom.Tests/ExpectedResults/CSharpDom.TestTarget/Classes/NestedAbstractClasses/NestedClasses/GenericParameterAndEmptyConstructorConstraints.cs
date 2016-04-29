namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedClasses
{
    public class ClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
