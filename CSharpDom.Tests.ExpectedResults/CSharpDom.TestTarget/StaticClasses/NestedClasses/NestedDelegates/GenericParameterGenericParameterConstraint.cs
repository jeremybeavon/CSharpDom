namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedDelegates
{
    public static class StaticClassWithNestedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
