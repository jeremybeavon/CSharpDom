namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Methods
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithMethodWithParametersWithModifiers
    {
        public abstract class Class
        {
            public void Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
