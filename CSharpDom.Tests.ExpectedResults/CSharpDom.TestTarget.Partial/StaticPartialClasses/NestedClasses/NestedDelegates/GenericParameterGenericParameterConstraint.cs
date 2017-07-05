namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
