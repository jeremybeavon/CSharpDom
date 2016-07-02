namespace CSharpDom.TestTarget.Classes.NestedSealedClasses
{
    public class ClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
