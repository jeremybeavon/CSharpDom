namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Methods
{
    public sealed class SealedClassWithNestedClassWithMethodWithGenericParameterStructConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
