namespace CSharpDom.Common.Editable
{
    public interface IHasEditableSealedClassMemberInheritanceModifier : IHasSealedClassMemberInheritanceModifier
    {
        new SealedClassMemberInheritanceModifier InheritanceModifier { get; set; }
    }
}