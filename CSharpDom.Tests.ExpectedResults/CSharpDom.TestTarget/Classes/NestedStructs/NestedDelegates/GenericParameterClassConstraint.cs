namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedDelegates
{
    public class ClassWithNestedStructWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
