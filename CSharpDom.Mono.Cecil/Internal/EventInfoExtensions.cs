using System.Reflection;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal static class EventInfoExtensions
    {
        public static ClassMemberVisibilityModifier ClassVisibility(this EventInfo @event)
        {
            return @event.AddMethod.ClassVisibility();
        }

        public static SealedClassMemberInheritanceModifier SealedClassInheritanceModifier(
            this EventInfo @event,
            IInternalTypeWithMonoCecil type)
        {
            return @event.AddMethod.SealedClassInheritanceModifier(() => type.HiddenMembersAnalyzer.IsEventHidden(@event));
        }

        public static ClassMemberInheritanceModifier InheritanceModifier(this EventInfo @event, IInternalTypeWithMonoCecil type)
        {
            return @event.AddMethod.InheritanceModifier(() => type.HiddenMembersAnalyzer.IsEventHidden(@event));
        }
        
        public static bool IsOverride(this EventInfo @event)
        {
            return @event.AddMethod.IsOverride();
        }
    }
}
