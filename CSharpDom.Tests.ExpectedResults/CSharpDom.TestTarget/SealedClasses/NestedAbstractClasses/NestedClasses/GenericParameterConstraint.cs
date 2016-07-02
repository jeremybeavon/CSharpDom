namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
