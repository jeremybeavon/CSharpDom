namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
