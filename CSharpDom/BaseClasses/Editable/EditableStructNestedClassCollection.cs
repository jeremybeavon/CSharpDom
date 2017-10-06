using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> :
        EditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>,
        IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
        where TClass : IStructNestedClass
        where TAbstractClass : IStructNestedAbstractClass
        where TSealedClass : IStructNestedSealedClass
        where TStaticClass : IStructNestedStaticClass
        where TPartialClassCollection : IPartialClassCollection
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructNestedClassCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructNestedClassCollectionChildren(this, visitor);
        }
    }
}
