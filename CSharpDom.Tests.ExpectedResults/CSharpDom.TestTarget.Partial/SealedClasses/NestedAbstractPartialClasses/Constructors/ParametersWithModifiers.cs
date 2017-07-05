namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Constructors
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithConstructorWithParametersWithModifiers
    {
        public abstract partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
