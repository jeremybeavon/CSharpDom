using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using System.Linq;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class EnumWithMonoCecil :
        AbstractEnum<
            NamespaceWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AttributeWithMonoCecil,
            EnumMemberWithMonoCecil>,
        IHasTypeDefinition,
        ITypeWithMonoCecil//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithMonoCecil assembly;
        private readonly NamespaceWithMonoCecil @namespace;
        private readonly TypeDefinition type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<IReadOnlyList<EnumMemberWithMonoCecil>> enumMembers;

        internal EnumWithMonoCecil(AssemblyWithMonoCecil assembly, NamespaceWithMonoCecil @namespace, TypeDefinition type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, type));
            enumMembers = new Lazy<IReadOnlyList<EnumMemberWithMonoCecil>>(InitializeEnumMembers);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override IReadOnlyList<EnumMemberWithMonoCecil> EnumMembers
        {
            get { return enumMembers.Value; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public override NamespaceWithMonoCecil Namespace
        {
            get { return @namespace; }
        }

        public override AssemblyWithMonoCecil Project
        {
            get { return assembly; }
        }

        public override AssemblyWithMonoCecil Solution
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

        public override AssemblyWithMonoCecil Document
        {
            get { return assembly; }
        }

        public AssemblyWithMonoCecil Assembly
        {
            get { return assembly; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitEnumWithMonoCecil(this);
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

        private IReadOnlyList<EnumMemberWithMonoCecil> InitializeEnumMembers()
        {
            return type.Fields
                .Where(field => field.IsPublic && field.IsStatic)
                .Select(field => new EnumMemberWithMonoCecil(this, field))
                .ToList();
        }
    }
}
