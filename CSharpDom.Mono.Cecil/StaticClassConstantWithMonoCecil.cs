﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using Mono.Cecil;
using CSharpDom.NotSupported;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Mono.Cecil.ConstantExpressions;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassConstantWithMonoCecil :
        AbstractStaticClassConstant<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IConstantWithMonoCecil>,
        IConstantWithMonoCecil
    {
        private readonly ConstantGroupWithMonoCecil constant;

        internal StaticClassConstantWithMonoCecil(ITypeWithMonoCecil declaringType, FieldDefinition field)
        {
            constant = new ConstantGroupWithMonoCecil(declaringType, field);
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
