using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class EnumWithCodeAnalysis :
        AbstractEnum<
            NamespaceWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            EnumMemberWithCodeAnalysis>,
        IHasTypeDefinition,
        ITypeWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithCodeAnalysis assembly;
        private readonly NamespaceWithCodeAnalysis @namespace;
        private readonly TypeDefinition type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<IReadOnlyList<EnumMemberWithCodeAnalysis>> enumMembers;

        internal EnumWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, NamespaceWithCodeAnalysis @namespace, TypeDefinition type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, type));
            enumMembers = new Lazy<IReadOnlyList<EnumMemberWithCodeAnalysis>>(InitializeEnumMembers);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override IReadOnlyList<EnumMemberWithCodeAnalysis> EnumMembers
        {
            get { return enumMembers.Value; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public override NamespaceWithCodeAnalysis Namespace
        {
            get { return @namespace; }
        }

        public override AssemblyWithCodeAnalysis Project
        {
            get { return assembly; }
        }

        public override AssemblyWithCodeAnalysis Solution
        {
            get { return assembly; }
        }

        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return type.Visibility(); }
        }

        public override EnumBaseType BaseType
        {
            get { return GetBaseType(type); }
        }

        public override AssemblyWithCodeAnalysis Document
        {
            get { return assembly; }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return assembly; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitEnumWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/

        internal static EnumBaseType GetBaseType(TypeDefinition type)
        {
            throw new NotImplementedException();
            /*switch (TypeDefinition.GetTypeCode(Enum.GetUnderlyingType(type)))
            {
                case TypeCode.Byte:
                    return EnumBaseType.Byte;
                case TypeCode.Int64:
                    return EnumBaseType.Long;
                case TypeCode.SByte:
                    return EnumBaseType.SByte;
                case TypeCode.Int16:
                    return EnumBaseType.Short;
                case TypeCode.UInt32:
                    return EnumBaseType.UInt;
                case TypeCode.UInt64:
                    return EnumBaseType.ULong;
                case TypeCode.UInt16:
                    return EnumBaseType.UShort;
                default:
                    return EnumBaseType.None;
            }*/
        }

        private IReadOnlyList<EnumMemberWithCodeAnalysis> InitializeEnumMembers()
        {
            return type.Fields
                .Where(field => field.IsPublic && field.IsStatic)
                .Select(field => new EnumMemberWithCodeAnalysis(this, field))
                .ToList();
        }
    }
}
