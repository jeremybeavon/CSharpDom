namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedSealedClasses
{
    public class ClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
