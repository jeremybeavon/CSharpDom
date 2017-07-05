namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
