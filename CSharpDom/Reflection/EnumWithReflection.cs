using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System.Linq;

namespace CSharpDom.Reflection
{
    public sealed class EnumWithReflection :
        AbstractEnum<
            NamespaceWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AttributeWithReflection,
            EnumMemberWithReflection>,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithReflection assembly;
        private readonly NamespaceWithReflection @namespace;
        private readonly Type type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<IReadOnlyList<EnumMemberWithReflection>> enumMembers;

        internal EnumWithReflection(AssemblyWithReflection assembly, NamespaceWithReflection @namespace, Type type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(type));
            enumMembers = new Lazy<IReadOnlyList<EnumMemberWithReflection>>(InitializeEnumMembers);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override IReadOnlyList<EnumMemberWithReflection> EnumMembers
        {
            get { return enumMembers.Value; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public override NamespaceWithReflection Namespace
        {
            get { return @namespace; }
        }

        public override AssemblyWithReflection Project
        {
            get { return assembly; }
        }

        public override AssemblyWithReflection Solution
        {
            get { return assembly; }
        }

        public Type Type
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

        public override AssemblyWithReflection Document
        {
            get { return assembly; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitEnumWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/

        internal static EnumBaseType GetBaseType(Type type)
        {
            switch (Type.GetTypeCode(Enum.GetUnderlyingType(type)))
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
            }
        }

        private IReadOnlyList<EnumMemberWithReflection> InitializeEnumMembers()
        {
            return type.GetAllFields().Select(field => new EnumMemberWithReflection(this, field)).ToList();
        }
    }
}
