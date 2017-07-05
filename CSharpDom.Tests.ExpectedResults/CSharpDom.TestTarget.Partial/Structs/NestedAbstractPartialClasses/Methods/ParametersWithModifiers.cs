namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Methods
{
    public struct StructWithNestedAbstractPartialClassWithMethodWithParametersWithModifiers
    {
        public abstract partial class Class
        {
            public void Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
