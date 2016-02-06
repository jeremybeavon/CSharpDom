﻿using CSharpDom.Common;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassIndexer
    {
        private EmptyClassPropertyAccessors emptyAccessors;
        private ClassAccessor getAccessor;
        private ClassAccessor setAccessor;

        public ClassIndexer()
        {
            Parameters = new Collection<MethodParameter>();
        }
        
        public ClassMemberVisibilityModifier Visibility { get; set; }

        public IndexerInheritanceModifier InheritanceModifier { get; set; }

        public TypeReference Type { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }

        public EmptyClassPropertyAccessors EmptyAccessors
        {
            get
            {
                return emptyAccessors;
            }

            set
            {
                emptyAccessors = value;
                if (value != null)
                {
                    getAccessor = null;
                    setAccessor = null;
                }
            }
        }

        public ClassAccessor GetAccessor
        {
            get
            {
                return getAccessor;
            }

            set
            {
                getAccessor = value;
                if (value != null)
                {
                    emptyAccessors = null;
                }
            }
        }

        public ClassAccessor SetAccessor
        {
            get
            {
                return setAccessor;
            }

            set
            {
                setAccessor = value;
                if (value != null)
                {
                    emptyAccessors = null;
                }
            }
        }
    }
}
