namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Methods
{
    public struct StructWithNestedSealedPartialClassWithMethodWithParametersWithModifiers
    {
        public sealed partial class Class
        {
            public void Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
