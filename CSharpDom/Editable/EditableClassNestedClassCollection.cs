using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        EditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>,
        IClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IClassNestedClass
        where TAbstractClass : IClassNestedAbstractClass
        where TSealedClass : IClassNestedSealedClass
        where TStaticClass : IClassNestedStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassNestedClassCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassNestedClassCollectionChildren(this, visitor);
        }
    }
}
