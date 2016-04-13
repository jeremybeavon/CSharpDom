﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class SealedClassNestedInterfaceCollection : AbstractClassNestedInterfaceCollection
    {
        private readonly SealedTypeWithMonoCecil typeWithMonoCecil;

        internal SealedClassNestedInterfaceCollection(SealedTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }
        
        protected override IReadOnlyCollection<ClassNestedInterfaceWithMonoCecil> Interfaces
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedInterfaces; }
        }
    }
}