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

        public async Task TestForStatement()
        {
            try
            {
                SolutionWithLinqExpressions solution = await SolutionWithReflection.OpenSolutionAsync(solutionFile);
                ProjectWithReflection project = solution.Projects.Single(proj => proj.Project.Name == "CSharpDom");
                ClassWithReflection methodNodeClass = await project.Classes.GetSingle(
                    document => Path.GetFileName(document.FullFilePath) == "PropertyWithReflection.cs",
                    @class => true);
                PropertyWithReflection property = methodNodeClass.Properties.Single(prop => prop.Name == "Name");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
