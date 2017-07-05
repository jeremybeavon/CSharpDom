namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Constructors
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithConstructorWithParametersWithModifiers
    {
        public sealed class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
