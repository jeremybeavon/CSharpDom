namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
