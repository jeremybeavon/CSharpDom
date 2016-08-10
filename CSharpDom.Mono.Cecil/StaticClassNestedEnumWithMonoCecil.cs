using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassNestedEnumWithMonoCecil :
        AbstractStaticClassNestedEnum<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            NestedEnumMemberWithMonoCecil>
    {
        private readonly NestedEnumWithMonoCecil nestedEnum;

        internal StaticClassNestedEnumWithMonoCecil(ITypeWithMonoCecil declaringType, TypeDefinition type)
        {
            nestedEnum = new NestedEnumWithMonoCecil(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return nestedEnum.Attributes; }
        }

        public override EnumBaseType BaseType
        {
            get { return nestedEnum.BaseType; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return nestedEnum.DeclaringType; }
        }

        public override IReadOnlyList<NestedEnumMemberWithMonoCecil> EnumMembers
        {
            get { return nestedEnum.EnumMembers; }
        }

        public override string Name
        {
            get { return nestedEnum.Name; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedEnum.TypeDefinition.ClassMemberVisibility(); }
        }
    }
}
