namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedAbstractClasses
{
    public class ClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
