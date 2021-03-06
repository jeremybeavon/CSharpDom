﻿using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class ProjectSyntaxList : AbstractChildSyntaxCollection<Solution, Project>, IHasSyntax<Solution>
    {
        private readonly Node<SolutionWithCodeAnalysis, Solution> node;

        public ProjectSyntaxList(Node<SolutionWithCodeAnalysis, Solution> node)
        {
            this.node = node;
        }

        public override int Count
        {
            get { return Syntax.ProjectIds.Count; }
        }
        
        public Solution Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override Project this[int index]
        {
            get { return Syntax.Projects.ElementAt(index); }
        }

        public override void Add(Project item)
        {
            throw new NotSupportedException();
        }

        public override void Clear()
        {
            Solution syntax = Syntax;
            foreach (ProjectId project in node.Syntax.ProjectIds)
            {
                syntax = syntax.RemoveProject(project);
            }

            Syntax = syntax;
        }

        public override bool Contains(Project item)
        {
            return Syntax.ContainsProject(item.Id);
        }

        public override IEnumerator<Project> GetEnumerator()
        {
            return Syntax.Projects.GetEnumerator();
        }
        
        public override bool Remove(Project item)
        {
            Syntax = Syntax.RemoveProject(item.Id);
            return true;
        }
    }
}
