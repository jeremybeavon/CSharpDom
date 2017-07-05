namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithMethodWithParametersWithModifiers
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
