namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
