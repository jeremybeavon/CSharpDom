using CSharpDom.TestTarget.SealedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Destructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithDestructorUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithDestructor));
        }
    }
}
