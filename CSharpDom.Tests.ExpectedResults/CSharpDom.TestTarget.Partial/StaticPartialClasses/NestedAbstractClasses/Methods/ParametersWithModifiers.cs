namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Methods
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithMethodWithParametersWithModifiers
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
