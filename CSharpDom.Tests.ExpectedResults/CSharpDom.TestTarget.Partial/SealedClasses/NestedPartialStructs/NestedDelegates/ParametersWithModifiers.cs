namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedDelegates
{
    public sealed class SealedClassWithNestedStructWithNestedDelegateWithParametersWithModifiers
    {
        public struct Struct
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
