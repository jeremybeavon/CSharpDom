using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;
using CSharpDom.Reflection.ConstantExpressions;
using CSharpDom.NotSupported;

namespace CSharpDom.Reflection
{
    public sealed class StructConstantWithReflection :
        AbstractStructConstant<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            IConstantWithReflection>,
        IConstantWithReflection
    {
        private readonly ConstantGroupWithReflection constant;

        internal StructConstantWithReflection(ITypeWithReflection declaringType, FieldInfo field)
        {
            this.constant = new ConstantGroupWithReflection(declaringType, field);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return constant.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return constant.DeclaringType; }
        }

        public override IReadOnlyCollection<IConstantWithReflection> Constants
        {
            get { return new IConstantWithReflection[] { new InternalConstantWithReflection(constant) }; }
        }

        public override ITypeReferenceWithReflection FieldType
        {
            get { return constant.FieldType; }
        }

        public IConstantExpressionWithReflection ConstantValue
        {
            get { return constant.ConstantValue; }
        }

        public string Name
        {
            get { return constant.FieldInfo.Name; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get
            {
                FieldInfo fieldInfo = constant.FieldInfo;
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
