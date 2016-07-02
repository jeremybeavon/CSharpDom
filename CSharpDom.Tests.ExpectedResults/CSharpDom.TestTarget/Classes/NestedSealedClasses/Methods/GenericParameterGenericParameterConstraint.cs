namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods
{
    public class ClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
