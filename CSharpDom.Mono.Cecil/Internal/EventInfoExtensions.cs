﻿using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal static class EventInfoExtensions
    {
        public static ClassMemberVisibilityModifier ClassVisibility(this EventDefinition @event)
        {
            return @event.AddMethod.ClassVisibility();
        }

        public static SealedClassMemberInheritanceModifier SealedClassInheritanceModifier(
            this EventDefinition @event,
            IInternalTypeWithMonoCecil type)
        {
            return @event.AddMethod.SealedClassInheritanceModifier(() => type.HiddenMembersAnalyzer.IsEventHidden(@event));
        }

        public static ClassMemberInheritanceModifier InheritanceModifier(this EventDefinition @event, IInternalTypeWithMonoCecil type)
        {
            return @event.AddMethod.InheritanceModifier(() => type.HiddenMembersAnalyzer.IsEventHidden(@event));
        }
        
        public static bool IsOverride(this EventDefinition @event)
        {
            return @event.AddMethod.HasOverrides;
        }
    }
}
