using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.CodeAnalysis.Internal;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Mono.Cecil.ConstantExpressions;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassConstantWithCodeAnalysis :
        AbstractClassConstant<
            AttributeGroupWithCodeAnalysis,
            IClassTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IConstantWithCodeAnalysis>,
        IConstantWithCodeAnalysis
    {
        private readonly ConstantGroupWithCodeAnalysis constant;
        private readonly IInternalTypeWithCodeAnalysis declaringType;

        internal ClassConstantWithCodeAnalysis(IInternalTypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            this.constant = new ConstantGroupWithCodeAnalysis(declaringType, field);
            this.declaringType = declaringType;
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return constant.Attributes; }
        }

        public override IReadOnlyCollection<IConstantWithCodeAnalysis> Constants
        {
            get { return new IConstantWithCodeAnalysis[] { new InternalConstantWithCodeAnalysis(constant) }; }
        }

        public IConstantExpressionWithCodeAnalysis ConstantValue
        {
            get { return constant.ConstantValue; }
        }

        public override IClassTypeWithCodeAnalysis DeclaringType
        {
            get { return (IClassTypeWithCodeAnalysis)declaringType; }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
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
