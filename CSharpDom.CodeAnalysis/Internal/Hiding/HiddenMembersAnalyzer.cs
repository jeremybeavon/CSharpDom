using CSharpDom.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Internal.Hiding
{
    internal sealed class HiddenMembersAnalyzer
    {
        private readonly AssemblyWithCodeAnalysis assembly;
        private readonly TypeDefinition type;
        private readonly Lazy<ISet<string>> events;
        private readonly Lazy<ISet<string>> fields;
        private readonly Lazy<ISet<string>> indexers;
        private readonly Lazy<ISet<string>> methods;
        private readonly Lazy<ISet<string>> properties;

        public HiddenMembersAnalyzer(AssemblyWithCodeAnalysis assembly, TypeDefinition type)
        {
            this.assembly = assembly;
            this.type = type;
            events = new Lazy<ISet<string>>(FindEvents);
            fields = new Lazy<ISet<string>>(FindFields);
            indexers = new Lazy<ISet<string>>(FindIndexers);
            methods = new Lazy<ISet<string>>(FindMethods);
            properties = new Lazy<ISet<string>>(FindProperties);
        }

        public bool IsEventHidden(EventDefinition @event)
        {
            return !@event.AddMethod.HasOverrides && events.Value.Contains(ToString(@event));
        }
        
        public bool IsFieldHidden(FieldDefinition field)
        {
            return fields.Value.Contains(ToString(field));
        }

        public bool IsIndexerHidden(PropertyDefinition indexer)
        {
            return !indexer.IsOverride() && indexers.Value.Contains(ToIndexerString(indexer));
        }

        public bool IsMethodHidden(MethodDefinition method)
        {
            return !method.HasOverrides && methods.Value.Contains(ToString(method));
        }

        public bool IsPropertyHidden(PropertyDefinition property)
        {
            return !property.IsOverride() && properties.Value.Contains(ToString(property));
        }

        private static string ToString(EventDefinition @event)
        {
            return @event.Name;
        }

        private static string ToString(FieldDefinition field)
        {
            return field.Name;
        }

        private string ToIndexerString(PropertyDefinition indexer)
        {
            return new IndexerSignature(assembly, indexer).ToSourceCode();
        }

        private string ToString(MethodDefinition method)
        {
            return new MethodSignature(assembly, method).ToSourceCode();
        }
        
        private static string ToString(PropertyDefinition property)
        {
            return property.Name;
        }

        private ISet<string> FindEvents()
        {
            return FindMembers(baseType => baseType.Events.ToArray(), @event => @event.ClassVisibility(), ToString);
        }

        private ISet<string> FindFields()
        {
            return FindMembers(baseType => baseType.Fields.ToArray(), field => field.ClassVisibility(), ToString);
        }

        private ISet<string> FindIndexers()
        {
            return FindMembers(
                baseType => baseType.Properties.Where(property => property.Parameters.Any()).ToArray(),
                indexer => indexer.ClassVisibility(),
                ToIndexerString);
        }

        private ISet<string> FindMethods()
        {
            return FindMembers(baseType => baseType.Methods.ToArray(), method => method.ClassVisibility(), ToString);
        }

        private ISet<string> FindProperties()
        {
            return FindMembers(
                baseType => baseType.Properties.Where(property => !property.Parameters.Any()).ToArray(),
                property => property.ClassVisibility(),
                ToString);
        }

        private ISet<string> FindMembers<T>(
            Func<TypeDefinition, T[]> getMembersFunc,
            Func<T, ClassMemberVisibilityModifier> visibilityFunc,
            Func<T, string> toStringFunc)
            where T : MemberReference
        {
            HashSet<string> set = new HashSet<string>();
            for (TypeDefinition baseType = type.BaseType.Resolve(); baseType != null; baseType = baseType.BaseType?.Resolve())
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

        private bool IsParentType(TypeReference baseType)
        {
            for (TypeReference parentType = type.DeclaringType; parentType != null; parentType = parentType.DeclaringType)
            {
                if (parentType == baseType)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsInSameAssembly(TypeReference baseType)
        {
            return type.Module == baseType.Module;
        }
    }
}
