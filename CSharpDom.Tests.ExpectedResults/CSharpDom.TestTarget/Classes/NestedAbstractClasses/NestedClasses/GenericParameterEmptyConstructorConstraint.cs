namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedClasses
{
    public class ClassWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
