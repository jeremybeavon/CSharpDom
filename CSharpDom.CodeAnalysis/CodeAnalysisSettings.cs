using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public static class CodeAnalysisSettings
    {
        private static readonly ISet<INode> editedNodes = new HashSet<INode>();

        internal static bool AreEditsAllowed { get; set; }

        public static IDisposable AllowEdits<TSyntax>(params IHasSyntax<TSyntax>[] editableObjects)
            where TSyntax : class
        {
            foreach (IHasSyntax<TSyntax> editableObject in editableObjects)
            {
                IHasNode<TSyntax> node = editableObject as IHasNode<TSyntax>;
                if (node == null)
                {
                    throw new InvalidOperationException(editableObject.GetType().FullName + " is not set up for edits.");
                }

                editedNodes.Add(node.Node);
            }

            return new DisposableValue();
        }

        private static void RefreshAndClearEditedNodes()
        {
            RefreshNodes(editedNodes);
            editedNodes.Clear();
        }

        private static void RefreshNodes(IEnumerable<INode> nodes)
        {
            foreach (INode node in nodes)
            {
                if (node.ChildNodes.Count == 0)
                {
                    node.RefreshSyntax();
                }
                else
                {
                    foreach (INode childNode in node.ChildNodes)
                    {
                        RefreshNodes(childNode.ChildNodes);
                    }
                }
            }
        }
        
        private sealed class DisposableValue : IDisposable
        {
            private readonly bool areEditsAllowed;


            public DisposableValue()
            {
                areEditsAllowed = AreEditsAllowed;
                AreEditsAllowed = true;
            }

            public void Dispose()
            {
                AreEditsAllowed = areEditsAllowed;
                if (!AreEditsAllowed)
                {
                    RefreshAndClearEditedNodes();
                }
            }
        }
    }
}
