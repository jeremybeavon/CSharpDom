using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassNestedDelegateWithReflection :
        AbstractStaticClassNestedDelegate<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            DelegateParameterWithReflection>
    {
        private readonly NestedDelegateWithReflection nestedDelegate;

        internal StaticClassNestedDelegateWithReflection(ITypeWithReflection declaringType, Type type)
        {
            nestedDelegate = new NestedDelegateWithReflection(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return nestedDelegate.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return nestedDelegate.DeclaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return nestedDelegate.GenericParameters; }
        }

        public override string Name
        {
            get { return nestedDelegate.Name; }
        }

        public override IReadOnlyList<DelegateParameterWithReflection> Parameters
        {
            get { return nestedDelegate.Parameters; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return nestedDelegate.ReturnType; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedDelegate.Type.ClassMemberVisibility(); }
        }
    }
}
