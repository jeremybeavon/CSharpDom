namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses
{
    public class ClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public abstract class Class<T>
            where T : class
        {
        }
    }
}
