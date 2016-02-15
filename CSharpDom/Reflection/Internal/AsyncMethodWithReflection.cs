using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using CSharpDom.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class AsyncMethodWithReflection :
        AbstractAsyncMethod<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            MethodParameterWithReflection,
            ILMethodBodyWithReflectionEmit>,
        IHasMethodInfo
    {
        private readonly MethodWithReflection method;
        private readonly ITypeReferenceWithReflection taskGenericParameter;

        public AsyncMethodWithReflection(ITypeWithReflection declaringType, MethodInfo method)
        {
            this.method = new MethodWithReflection(declaringType, method);
            if (method.ReturnType.IsGenericType)
            {
                taskGenericParameter = TypeReferenceWithReflectionFactory.CreateReference(method.GetGenericArguments()[0]);
            }
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

        public MethodInfo MethodInfo
        {
            get { return method.MethodInfo; }
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
            get { return taskGenericParameter; }
        }
    }
}
