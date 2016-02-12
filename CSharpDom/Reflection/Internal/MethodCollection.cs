using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class MethodCollection<TMethod, TType> :
        VisitableNotSupported<IGenericVisitor>,
        IMethodCollection
        where TType : ITypeWithReflection
    {
        private readonly Lazy<Methods<TMethod, TType>> methods;

        public MethodCollection(Func<Methods<TMethod, TType>> methods)
        {
            this.methods = new Lazy<Methods<TMethod, TType>>(methods);
        }

        public Methods<TMethod, TType> Methods
        {
            get { return methods.Value; }
        }
    }
}
