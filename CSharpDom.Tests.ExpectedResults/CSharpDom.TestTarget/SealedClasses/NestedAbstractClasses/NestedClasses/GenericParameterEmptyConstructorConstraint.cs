namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
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
