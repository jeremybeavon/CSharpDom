namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Methods
{
    public class ClassWithNestedPartialClassWithMethodWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public Dictionary<TKey, TValue> Method<TKey, TValue>()
                where TValue : TKey
            {
                return default(Dictionary<TKey, TValue>);
            }
        }
    }
}
