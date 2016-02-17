using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ExplicitInterfaceMethodWithReflection :
        AbstractExplicitInterfaceMethod<
            AttributeWithReflection,
            ITypeWithReflection,
            InterfaceReferenceWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            MethodParameterWithReflection,
            ILMethodBodyWithReflectionEmit>
    {
        private readonly MethodWithReflection method;
        private readonly InterfaceReferenceWithReflection explicitInterface;

        internal ExplicitInterfaceMethodWithReflection(ITypeWithReflection declaringType, Type interfaceType, MethodInfo method)
        {
            this.method = new MethodWithReflection(declaringType, method);
            explicitInterface = new InterfaceReferenceWithReflection(interfaceType);
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

        public override InterfaceReferenceWithReflection ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return method.GenericParameters; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }

        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithReflection> Parameters
        {
            get { return method.Parameters; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return method.ReturnType; }
        }
    }
}
