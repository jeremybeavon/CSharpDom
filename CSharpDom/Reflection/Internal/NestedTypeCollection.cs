using System;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class NestedTypeCollection<
        TNestedAbstractClass,
        TNestedClass,
        TNestedSealedClass,
        TNestedStaticClass,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStruct>
    {
        private readonly Lazy<NestedTypes<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>> nestedTypes;

        public NestedTypeCollection(Func<NestedTypes<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>> nestedTypes)
        {
            this.nestedTypes = new Lazy<NestedTypes<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>>(nestedTypes);
        }

        public NestedTypes<TNestedAbstractClass, TNestedClass, TNestedSealedClass, TNestedStaticClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> NestedTypes
        {
            get { return nestedTypes.Value; }
        }
    }
}
