using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.NotSupported;
using CSharpDom.CodeAnalysis.Internal;
using CSharpDom.Mono.Cecil.ConstantExpressions;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassConstantWithCodeAnalysis :
        AbstractStaticClassConstant<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IConstantWithCodeAnalysis>,
        IConstantWithCodeAnalysis
    {
        private readonly ConstantGroupWithCodeAnalysis constant;

        internal StaticClassConstantWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            constant = new ConstantGroupWithCodeAnalysis(declaringType, field);
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

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get
            {
                FieldDefinition fieldInfo = constant.FieldDefinition;
                if (fieldInfo.IsPublic)
                {
                    return StaticClassMemberVisibilityModifier.Public;
                }

                if (fieldInfo.IsAssembly)
                {
                    return StaticClassMemberVisibilityModifier.Internal;
                }

                if (fieldInfo.IsPrivate)
                {
                    return StaticClassMemberVisibilityModifier.Private;
                }

                return StaticClassMemberVisibilityModifier.None;
            }
        }
    }
}
