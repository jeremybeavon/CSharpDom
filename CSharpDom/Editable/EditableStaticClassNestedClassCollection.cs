using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        EditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>,
        IStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IStaticClassNestedClass
        where TAbstractClass : IStaticClassNestedAbstractClass
        where TSealedClass : IStaticClassNestedSealedClass
        where TStaticClass : IStaticClassNestedStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassNestedClassCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassNestedClassCollectionChildren(this, visitor);
        }
    }
}
