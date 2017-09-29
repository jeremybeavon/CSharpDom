using CSharpDom.TestTarget.SealedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Destructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithDestructorUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithDestructor));
        }
    }
}
