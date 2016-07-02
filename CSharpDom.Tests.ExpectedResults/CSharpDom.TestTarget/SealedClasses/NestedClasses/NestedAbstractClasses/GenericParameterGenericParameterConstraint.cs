namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public abstract class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
