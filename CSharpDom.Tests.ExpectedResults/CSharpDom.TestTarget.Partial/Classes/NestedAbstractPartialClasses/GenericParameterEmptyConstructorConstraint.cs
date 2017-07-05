namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractClasses
{
    public class ClassWithNestedAbstractPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class<T>
            where T : new()
        {
        }
    }
}
