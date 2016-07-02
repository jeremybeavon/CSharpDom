namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
