namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedDelegates
{
    public struct StructWithNestedAbstractPartialClassWithNestedDelegateWithParametersWithModifiers
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
