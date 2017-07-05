namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractClasses
{
    public class ClassWithNestedAbstractPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, new()
        {
        }
    }
}
