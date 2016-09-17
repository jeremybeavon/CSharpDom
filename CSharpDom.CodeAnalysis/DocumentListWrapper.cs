﻿using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class DocumentListWrapper : BaseCollection<Document>, IHasSyntax<Project>
    {
        private readonly Node<ProjectWithCodeAnalysis, Project> node;

        public DocumentListWrapper(Node<ProjectWithCodeAnalysis, Project> node)
        {
            this.node = node;
        }

        public override int Count
        {
            get { return Syntax.DocumentIds.Count; }
        }

        public Project Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override void Add(Document item)
        {
            throw new NotImplementedException();
        }

        public override bool Contains(Document item)
        {
            return Syntax.ContainsDocument(item.Id);
        }

        public override void Clear()
        {
            Project syntax = Syntax;
            foreach (DocumentId document in syntax.DocumentIds)
            {
                syntax = syntax.RemoveDocument(document);
            }

            Syntax = syntax;
        }

        public override IEnumerator<Document> GetEnumerator()
        {
            return Syntax.Documents.GetEnumerator();
        }

        public override bool Remove(Document item)
        {
            Syntax = Syntax.RemoveDocument(item.Id);
            return true;
        }
    }
}
