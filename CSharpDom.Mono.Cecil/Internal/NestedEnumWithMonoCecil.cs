﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using System.Linq;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class NestedEnumWithMonoCecil :
        AbstractNestedEnum<AttributeWithMonoCecil, ITypeWithMonoCecil, NestedEnumMemberWithMonoCecil>,
        IHasTypeDefinition,
        ITypeWithMonoCecil//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly TypeDefinition type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<IReadOnlyList<NestedEnumMemberWithMonoCecil>> enumMembers;

        internal NestedEnumWithMonoCecil(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            this.declaringType = declaringType;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, type));
            enumMembers = new Lazy<IReadOnlyList<NestedEnumMemberWithMonoCecil>>(InitializeEnumMembers);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<NestedEnumMemberWithMonoCecil> EnumMembers
        {
            get { return enumMembers.Value; }
        }

        public override string Name
        {
            get { return type.Name; }
        }
        
        public TypeDefinition TypeDefinition
        {
            get { return type; }
        }

        public override EnumBaseType BaseType
        {
            get { return EnumWithMonoCecil.GetBaseType(type); }
        }

        public AssemblyWithMonoCecil Assembly
        {
            get { return declaringType.Assembly; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedEnumWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/

        private IReadOnlyList<NestedEnumMemberWithMonoCecil> InitializeEnumMembers()
        {
            return type.Fields
                .Where(field => field.IsPublic && field.IsStatic)
                .Select(field => new NestedEnumMemberWithMonoCecil(this, field))
                .ToList();
        }
    }
}
