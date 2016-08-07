using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using CSharpDom.NotSupported;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructConstantWithMonoCecil :
        AbstractStructConstant<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IConstantWithMonoCecil>,
        IConstantWithMonoCecil
    {
        private readonly ConstantGroupWithMonoCecil constant;

        internal StructConstantWithMonoCecil(ITypeWithMonoCecil declaringType, FieldDefinition field)
        {
            this.constant = new ConstantGroupWithMonoCecil(declaringType, field);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return constant.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return constant.DeclaringType; }
        }

        public override IReadOnlyCollection<IConstantWithMonoCecil> Constants
        {
            get { return new IConstantWithMonoCecil[] { new InternalConstantWithMonoCecil(constant) }; }
        }

        public override ITypeReferenceWithMonoCecil FieldType
        {
            get { return constant.FieldType; }
        }

        public IConstantExpressionWithMonoCecil ConstantValue
        {
            get { return constant.ConstantValue; }
        }

        public string Name
        {
            get { return constant.FieldDefinition.Name; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get
            {
                FieldDefinition fieldInfo = constant.FieldDefinition;
                if (fieldInfo.IsPublic)
                {
                    return StructMemberVisibilityModifier.Public;
                }

                if (fieldInfo.IsAssembly)
                {
                    return StructMemberVisibilityModifier.Internal;
                }
                
                if (fieldInfo.IsPrivate)
                {
                    return StructMemberVisibilityModifier.Private;
                }

                return StructMemberVisibilityModifier.None;
            }
        }
    }
}
