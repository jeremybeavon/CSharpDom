namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedDelegates
{
    public struct StructWithNestedSealedPartialClassWithNestedDelegateWithParametersWithModifiers
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
