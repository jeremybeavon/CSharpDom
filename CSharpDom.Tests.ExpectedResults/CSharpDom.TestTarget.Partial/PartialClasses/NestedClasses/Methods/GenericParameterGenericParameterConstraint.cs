namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Methods
{
    public partial class PartialClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint
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
