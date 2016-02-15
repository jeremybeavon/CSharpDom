using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using CSharpDom.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class AsyncExplicitInterfaceMethodWithReflection :
        AbstractAsyncExplicitInterfaceMethod<
            AttributeWithReflection,
            ITypeWithReflection,
            InterfaceReferenceWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            MethodParameterWithReflection,
            ILMethodBodyWithReflectionEmit>
    {
        private readonly AsyncMethodWithReflection method;

        internal AsyncExplicitInterfaceMethodWithReflection(ITypeWithReflection declaringType, MethodInfo method)
        {
            this.method = new AsyncMethodWithReflection(declaringType, method);
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

        public override InterfaceReferenceWithReflection ExplicitInterface
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
