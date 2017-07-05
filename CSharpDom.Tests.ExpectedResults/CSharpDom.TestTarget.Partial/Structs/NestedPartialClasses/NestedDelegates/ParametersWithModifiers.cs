namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedDelegates
{
    public struct StructWithNestedPartialClassWithNestedPartialClassWithNestedDelegateWithParametersWithModifiers
    {
        public partial class Class
        {
            public delegate void DelegateWithParametersWithModifiers(ref string parameter1, out string parameter2, params string[] parameters);
        }
    }
}
