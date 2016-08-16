using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStaticType<
        TEventCollection,
        TProperty,
        TMethodCollection,
        TFieldCollection,
        TNestedClassCollection,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterfaceCollection,
        TNestedStructCollection,
        TStaticConstructor> :
        IStaticType<TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>
        where TEventCollection : IStaticClassEventCollection
        where TProperty : IStaticClassProperty
        where TMethodCollection : IStaticClassMethodCollection
        where TFieldCollection : IStaticClassFieldCollection
        where TNestedClassCollection : IStaticClassNestedClassCollection
        where TNestedDelegate : IStaticClassNestedDelegate
        where TNestedEnum : IStaticClassNestedEnum
        where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
        where TNestedStructCollection : IStaticClassNestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
        public virtual TNestedClassCollection Classes { get; set; }
        
        public virtual IReadOnlyCollection<TNestedDelegate> Delegates { get; set; }

        public virtual IReadOnlyCollection<TNestedEnum> Enums { get; set; }

        public virtual TEventCollection Events { get; set; }

        public virtual TFieldCollection Fields { get; set; }
        
        public virtual TNestedInterfaceCollection Interfaces { get; set; }

        public virtual TMethodCollection Methods { get; set; }

        public virtual IReadOnlyCollection<TProperty> Properties { get; set; }

        public virtual TStaticConstructor StaticConstructor { get; set; }

        public virtual TNestedStructCollection Structs { get; set; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticType(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticTypeChildren(this, visitor);
        }
    }
}
