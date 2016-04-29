namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedAbstractClasses
{
    public class ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
