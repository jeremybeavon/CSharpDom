using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public static class CodeAnalysisSettings
    {
        private static readonly ISet<INode> editedNodes = new HashSet<INode>();

        public static string MsBuildExePath { get; set; }

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
            foreach (INode node in editedNodes)
            {
                RefreshNode(node);
            }

            editedNodes.Clear();
        }

        private static void RefreshNode(INode node)
        {
            if (node.ChildNodes.Count == 0)
            {
                node.RefreshSyntax();
            }
            else
            {
                foreach (INode childNode in node.ChildNodes.ToArray())
                {
                    RefreshNode(childNode);
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
                if (!areEditsAllowed)
                {
                    RefreshAndClearEditedNodes();
                }

                AreEditsAllowed = areEditsAllowed;
            }
        }
    }
}
