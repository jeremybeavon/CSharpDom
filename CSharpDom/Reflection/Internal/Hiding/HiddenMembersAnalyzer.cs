using CSharpDom.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal.Hiding
{
    internal sealed class HiddenMembersAnalyzer
    {
        private readonly Type type;
        private readonly Lazy<ISet<string>> events;
        private readonly Lazy<ISet<string>> fields;
        private readonly Lazy<ISet<string>> indexers;
        private readonly Lazy<ISet<string>> methods;
        private readonly Lazy<ISet<string>> properties;

        public HiddenMembersAnalyzer(Type type)
        {
            this.type = type;
            events = new Lazy<ISet<string>>(FindEvents);
            fields = new Lazy<ISet<string>>(FindFields);
            indexers = new Lazy<ISet<string>>(FindIndexers);
            methods = new Lazy<ISet<string>>(FindMethods);
            properties = new Lazy<ISet<string>>(FindProperties);
        }

        public bool IsEventHidden(EventInfo @event)
        {
            return !@event.IsOverride() && events.Value.Contains(ToString(@event));
        }
        
        public bool IsFieldHidden(FieldInfo field)
        {
            return fields.Value.Contains(ToString(field));
        }

        public bool IsIndexerHidden(PropertyInfo indexer)
        {
            return !indexer.IsOverride() && indexers.Value.Contains(ToIndexerString(indexer));
        }

        public bool IsMethodHidden(MethodInfo method)
        {
            return !method.IsOverride() && methods.Value.Contains(ToString(method));
        }

        public bool IsPropertyHidden(PropertyInfo property)
        {
            return !property.IsOverride() && properties.Value.Contains(ToString(property));
        }

        private static string ToString(EventInfo @event)
        {
            return @event.Name;
        }

        private static string ToString(FieldInfo field)
        {
            return field.Name;
        }

        private static string ToIndexerString(PropertyInfo indexer)
        {
            return new IndexerSignature(indexer).ToSourceCode();
        }

        private static string ToString(MethodInfo method)
        {
            return new MethodSignature(method).ToSourceCode();
        }
        
        private static string ToString(PropertyInfo property)
        {
            return property.Name;
        }

        private ISet<string> FindEvents()
        {
            return FindMembers(baseType => baseType.GetAllEvents(), @event => @event.ClassVisibility(), ToString);
        }

        private ISet<string> FindFields()
        {
            return FindMembers(baseType => baseType.GetAllFields(), field => field.ClassVisibility(), ToString);
        }

        private ISet<string> FindIndexers()
        {
            return FindMembers(
                baseType => baseType.GetAllProperties().Where(property => property.GetIndexParameters().Any()).ToArray(),
                indexer => indexer.ClassVisibility(),
                ToIndexerString);
        }

        private ISet<string> FindMethods()
        {
            return FindMembers(baseType => baseType.GetAllMethods(), method => method.ClassVisibility(), ToString);
        }

        private ISet<string> FindProperties()
        {
            return FindMembers(
                baseType => baseType.GetAllProperties().Where(property => !property.GetIndexParameters().Any()).ToArray(),
                property => property.ClassVisibility(),
                ToString);
        }

        private ISet<string> FindMembers<T>(
            Func<Type, T[]> getMembersFunc,
            Func<T, ClassMemberVisibilityModifier> visibilityFunc,
            Func<T, string> toStringFunc)
            where T : MemberInfo
        {
            HashSet<string> set = new HashSet<string>();
            for (Type baseType = type.BaseType; baseType != null; baseType = baseType.BaseType)
            {
                bool isParentType = IsParentType(baseType);
                bool isInSameAssembly = IsInSameAssembly(baseType);
                foreach (T member in getMembersFunc(baseType))
                {
                    if (CanBeHidden(visibilityFunc(member), isParentType, isInSameAssembly))
                    {
                        set.Add(toStringFunc(member));
                    }
                }
            }

            return set;
        }

        private bool CanBeHidden(ClassMemberVisibilityModifier visibility, bool isParentType, bool isInSameAssembly)
        {
            switch (visibility)
            {
                case ClassMemberVisibilityModifier.Public:
                case ClassMemberVisibilityModifier.Protected:
                case ClassMemberVisibilityModifier.ProtectedInternal:
                    return true;
                case ClassMemberVisibilityModifier.None:
                case ClassMemberVisibilityModifier.Private:
                    return isParentType;
                case ClassMemberVisibilityModifier.Internal:
                    return isInSameAssembly;
                default:
                    throw new NotSupportedException();
            }
        }

        private bool IsParentType(Type baseType)
        {
            for (Type parentType = type.DeclaringType; parentType != null; parentType = parentType.DeclaringType)
            {
                if (parentType == baseType)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsInSameAssembly(Type baseType)
        {
            return type.AssemblyQualifiedName == baseType.AssemblyQualifiedName;
        }
    }
}
