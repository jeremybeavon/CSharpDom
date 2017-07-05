namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedDelegates
{
    public class ClassWithNestedStructWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
