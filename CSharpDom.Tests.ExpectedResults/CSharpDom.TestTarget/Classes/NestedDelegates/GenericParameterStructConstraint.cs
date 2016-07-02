namespace CSharpDom.TestTarget.Classes.NestedDelegates
{
    public class ClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public delegate void DelegateWithGenericParameterStructConstraint<T>()
            where T : struct;
    }
}
