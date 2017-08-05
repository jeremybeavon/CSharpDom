using CSharpDom.TestTarget.AbstractClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Destructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithDestructorUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithDestructor));
        }
    }
}
