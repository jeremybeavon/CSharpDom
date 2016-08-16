using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructConstantWithCodeAnalysis :
        AbstractStructConstant<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IConstantWithCodeAnalysis>,
        IConstantWithCodeAnalysis
    {
        private readonly ConstantGroupWithCodeAnalysis constant;

        internal StructConstantWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            this.constant = new ConstantGroupWithCodeAnalysis(declaringType, field);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return constant.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return constant.DeclaringType; }
        }

        public override IReadOnlyCollection<IConstantWithCodeAnalysis> Constants
        {
            get { return new IConstantWithCodeAnalysis[] { new InternalConstantWithCodeAnalysis(constant) }; }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
        {
            get { return constant.FieldType; }
        }

        public IConstantExpressionWithCodeAnalysis ConstantValue
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
