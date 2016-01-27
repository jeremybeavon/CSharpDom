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
            AttributeWithReflection,
            EnumMemberWithReflection>,
        IHasType,
        IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyWithReflection assembly;
        private readonly NamespaceWithReflection @namespace;
        private readonly Type type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<IReadOnlyCollection<EnumMemberWithReflection>> enumMembers;

        internal EnumWithReflection(AssemblyWithReflection assembly, NamespaceWithReflection @namespace, Type type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(type));
            enumMembers = new Lazy<IReadOnlyCollection<EnumMemberWithReflection>>(InitializeEnumMembers);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override IReadOnlyCollection<EnumMemberWithReflection> EnumMembers
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


        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitEnumWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }

        private IReadOnlyCollection<EnumMemberWithReflection> InitializeEnumMembers()
        {
            return type.GetAllFields().Select(field => new EnumMemberWithReflection(this, field)).ToList();
        }
    }
}
