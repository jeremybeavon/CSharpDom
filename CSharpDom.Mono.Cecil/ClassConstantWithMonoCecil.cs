using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.NotSupported;
using Mono.Cecil;
using CSharpDom.Mono.Cecil.ConstantExpressions;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassConstantWithMonoCecil :
        AbstractClassConstant<
            AttributeWithMonoCecil,
            IClassTypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IConstantWithMonoCecil>,
        IConstantWithMonoCecil
    {
        private readonly ConstantGroupWithMonoCecil constant;
        private readonly IInternalTypeWithMonoCecil declaringType;

        internal ClassConstantWithMonoCecil(IInternalTypeWithMonoCecil declaringType, FieldDefinition field)
        {
            this.constant = new ConstantGroupWithMonoCecil(declaringType, field);
            this.declaringType = declaringType;
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return constant.Attributes; }
        }

        public override IReadOnlyCollection<IConstantWithMonoCecil> Constants
        {
            get { return new IConstantWithMonoCecil[] { new InternalConstantWithMonoCecil(constant) }; }
        }

        public IConstantExpressionWithMonoCecil ConstantValue
        {
            get { return constant.ConstantValue; }
        }

        public override IClassTypeWithMonoCecil DeclaringType
        {
            get { return (IClassTypeWithMonoCecil)declaringType; }
        }

        public override ITypeReferenceWithMonoCecil FieldType
        {
            get { return constant.FieldType; }
        }

        public string Name
        {
            get { return constant.FieldDefinition.Name; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return constant.FieldDefinition.ClassVisibility(); }
        }
    }
}
