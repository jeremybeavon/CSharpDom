using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class NestedEnumWithCodeAnalysis :
        AbstractNestedEnum<AttributeGroupWithCodeAnalysis, ITypeWithCodeAnalysis, NestedEnumMemberWithCodeAnalysis>,
        IHasTypeDefinition,
        ITypeWithCodeAnalysis//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly TypeDefinition type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<IReadOnlyList<NestedEnumMemberWithCodeAnalysis>> enumMembers;

        internal NestedEnumWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            this.declaringType = declaringType;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(declaringType.Assembly, type));
            enumMembers = new Lazy<IReadOnlyList<NestedEnumMemberWithCodeAnalysis>>(InitializeEnumMembers);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<NestedEnumMemberWithCodeAnalysis> EnumMembers
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
            get { return EnumWithCodeAnalysis.GetBaseType(type); }
        }

        public AssemblyWithCodeAnalysis Assembly
        {
            get { return declaringType.Assembly; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedEnumWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/

        private IReadOnlyList<NestedEnumMemberWithCodeAnalysis> InitializeEnumMembers()
        {
            return type.Fields
                .Where(field => field.IsPublic && field.IsStatic)
                .Select(field => new NestedEnumMemberWithCodeAnalysis(this, field))
                .ToList();
        }
    }
}
