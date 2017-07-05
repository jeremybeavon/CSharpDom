namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Constructors
{
    public sealed class SealedClassWithNestedSealedPartialClassWithConstructorWithParametersWithModifiers
    {
        public sealed partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
