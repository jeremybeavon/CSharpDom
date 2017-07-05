namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Constructors
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithConstructorWithParametersWithModifiers
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
