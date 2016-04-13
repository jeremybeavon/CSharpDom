using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Search
{
    public sealed class FindMethodVisitor : AbstractSearchVisitor<IMethod>
    {


        public override void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
        {
            base.VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(method);
        }
    }
}
