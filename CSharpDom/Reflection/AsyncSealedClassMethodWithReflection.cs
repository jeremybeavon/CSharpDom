using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using CSharpDom.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class AsyncSealedClassMethodWithReflection :
        AbstractAsyncSealedClassMethod<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            MethodParameterWithReflection,
            ILMethodBodyWithReflectionEmit>
    {
        private readonly AsyncMethodWithReflection method;
        private readonly IInternalTypeWithReflection declaringType;

        internal AsyncSealedClassMethodWithReflection(IInternalTypeWithReflection declaringType, MethodInfo method)
        {
            this.method = new AsyncMethodWithReflection(declaringType, method);
            this.declaringType = declaringType;
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return method.Attributes; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return method.Body; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return method.DeclaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return method.GenericParameters; }
        }
        
        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithReflection> Parameters
        {
            get { return method.Parameters; }
        }

        public override ITypeReferenceWithReflection TaskGenericParameter
        {
            get { return method.TaskGenericParameter; }
        }

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return method.MethodInfo.SealedClassInheritanceModifier(declaringType); }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return method.MethodInfo.ClassVisibility(); }
        }
    }
}
