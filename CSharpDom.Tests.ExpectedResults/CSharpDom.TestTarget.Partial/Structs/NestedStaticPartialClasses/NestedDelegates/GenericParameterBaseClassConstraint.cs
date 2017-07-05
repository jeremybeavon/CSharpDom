namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedDelegates
{
    public struct StructWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
