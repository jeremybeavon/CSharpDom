namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Methods
{
    public abstract class AbstractClassWithNestedSealedClassWithMethodWithParametersWithModifiers
    {
        public sealed class Class
        {
            public void Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
