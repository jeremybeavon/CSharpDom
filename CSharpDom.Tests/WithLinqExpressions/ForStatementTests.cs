using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpDom.Tests.WithLinqExpressions
{
    [TestClass]
    public sealed class ForStatementTests
    {
        private static readonly string solutionFile =
            Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\CSharpDom.sln"));

        [TestMethod]
        public async Task TestForStatement()
        {
            try
            {
                SolutionWithLinqExpressions solution = await SolutionWithLinqExpressions.OpenSolutionAsync(solutionFile);
                ProjectWithLinqExpressions project = solution.Projects.Single(proj => proj.Project.Name == "CSharpDom.TestLibrary");
                ClassWithLinqExpressions forLoopsClass = await project.Classes.GetSingle(
                    document => Path.GetFileName(document.FullFilePath) == "ForLoops.cs",
                    @class => true);
                MethodWithLinqExpressions method = forLoopsClass.Methods.Single(prop => prop.Name == "Sum");
                IImplementation implementation = method.Implementation;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
