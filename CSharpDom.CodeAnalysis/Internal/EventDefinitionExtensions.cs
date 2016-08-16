using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal static class EventDefinitionExtensions
    {
        public static ClassMemberVisibilityModifier ClassVisibility(this EventDefinition @event)
        {
            return @event.AddMethod.ClassVisibility();
        }

        public static SealedClassMemberInheritanceModifier SealedClassInheritanceModifier(
            this EventDefinition @event,
            IInternalTypeWithCodeAnalysis type)
        {
            return @event.AddMethod.SealedClassInheritanceModifier(() => type.HiddenMembersAnalyzer.IsEventHidden(@event));
        }

        public static ClassMemberInheritanceModifier InheritanceModifier(this EventDefinition @event, IInternalTypeWithCodeAnalysis type)
        {
            return @event.AddMethod.PropertyOrEventInheritanceModifier(() => type.HiddenMembersAnalyzer.IsEventHidden(@event));
        }
        
        public static bool IsOverride(this EventDefinition @event)
        {
            return @event.AddMethod.HasOverrides;
        }
    }
}
