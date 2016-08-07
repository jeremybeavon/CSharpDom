namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EmptyStaticClassPropertyAccessors
    {
        public EmptyStaticClassPropertyAccessors()
        {
        }

        public EmptyStaticClassPropertyAccessors(
            StaticClassAccessorVisibilityModifier getAccessorVisibility,
            StaticClassAccessorVisibilityModifier setAccessorVisibility)
        {
            getAccessorVisibility = GetAccessorVisibility;
            SetAccessorVisibility = setAccessorVisibility;
        }

        public StaticClassAccessorVisibilityModifier GetAccessorVisibility { get; set; }

        public StaticClassAccessorVisibilityModifier SetAccessorVisibility { get; set; }
    }
}
