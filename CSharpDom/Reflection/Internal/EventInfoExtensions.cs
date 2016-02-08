using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal static class EventInfoExtensions
    {
        public static ClassMemberVisibilityModifier ClassVisibility(this EventInfo @event)
        {
            return @event.AddMethod.ClassVisibility();
        }

        public static ClassMemberInheritanceModifier InheritanceModifier(this EventInfo @event, IInternalTypeWithReflection type)
        {
            return @event.AddMethod.InheritanceModifier(() => type.HiddenMembersAnalyzer.IsEventHidden(@event));
        }

        public static bool IsOverride(this EventInfo @event)
        {
            return @event.AddMethod.IsOverride();
        }
    }
}
