namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses
{
    public class ClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class<T>
            where T : new()
        {
        }
    }
}
