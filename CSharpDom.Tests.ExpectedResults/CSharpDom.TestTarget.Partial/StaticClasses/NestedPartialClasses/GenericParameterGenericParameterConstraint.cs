namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
