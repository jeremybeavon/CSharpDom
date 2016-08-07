using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;
using System.Reflection;
using CSharpDom.Reflection.ConstantExpressions;

namespace CSharpDom.Reflection
{
    public sealed class ClassConstantWithReflection :
        AbstractClassConstant<
            AttributeWithReflection,
            IClassTypeWithReflection,
            ITypeReferenceWithReflection,
            IConstantWithReflection>,
        IConstantWithReflection
    {
        private readonly ConstantGroupWithReflection constant;

        internal ClassConstantWithReflection(IInternalTypeWithReflection declaringType, FieldInfo field)
        {
            this.constant = new ConstantGroupWithReflection(declaringType, field);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return constant.Attributes; }
        }

        public override IClassTypeWithReflection DeclaringType
        {
            get { return (IClassTypeWithReflection)constant.DeclaringType; }
        }

        public override ITypeReferenceWithReflection FieldType
        {
            get { return constant.FieldType; }
        }
        
        public string Name
        {
            get { return constant.FieldInfo.Name; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return constant.FieldInfo.ClassVisibility(); }
        }

        public override IReadOnlyCollection<IConstantWithReflection> Constants
        {
            get { return new IConstantWithReflection[] { new InternalConstantWithReflection(constant) }; }
        }

        public IConstantExpressionWithReflection ConstantValue
        {
            get { return constant.ConstantValue; }
        }
    }
}
