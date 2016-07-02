namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedDelegates
{
    public class ClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
