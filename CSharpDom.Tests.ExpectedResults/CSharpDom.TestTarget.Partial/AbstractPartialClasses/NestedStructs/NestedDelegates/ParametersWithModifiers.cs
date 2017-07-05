namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedDelegateWithParametersWithModifiers
    {
        public struct Struct
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
