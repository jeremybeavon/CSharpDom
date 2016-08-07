using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ClassAccessorWithReflection :
        AbstractClassAccessor<AttributeWithReflection, ILMethodBodyWithReflectionEmit>,
        IHasMethodInfo
    {
        private readonly ClassAccessorVisibilityModifier visibility;
        private readonly AccessorWithReflection accessor;

        internal ClassAccessorWithReflection(IHasClassMemberVisibilityModifier parentVisibility, AccessorWithReflection accessor)
        {
            this.accessor = accessor;
            ClassMemberVisibilityModifier classVisibility = accessor.MethodInfo.ClassVisibility();
            if (parentVisibility.Visibility == classVisibility)
            {
                visibility = ClassAccessorVisibilityModifier.None;
            }
            else
            {
                switch (classVisibility)
                {
                    case ClassMemberVisibilityModifier.Internal:
                        visibility = ClassAccessorVisibilityModifier.Internal;
                        break;
                    case ClassMemberVisibilityModifier.ProtectedInternal:
                        visibility = ClassAccessorVisibilityModifier.ProtectedInternal;
                        break;
                    case ClassMemberVisibilityModifier.Protected:
                        visibility = ClassAccessorVisibilityModifier.Protected;
                        break;
                    case ClassMemberVisibilityModifier.Private:
                        visibility = ClassAccessorVisibilityModifier.Private;
                        break;
                }
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return accessor.Attributes; }
        }

        public override ClassAccessorVisibilityModifier Visibility
        {
            get { return visibility; }
        }

        public MethodInfo MethodInfo
        {
            get { return accessor.MethodInfo; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return accessor.Body; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAccessorWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
