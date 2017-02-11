using CSharpDom.TestTarget.SealedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Destructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithDestructorUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithDestructor));
        }
    }
}
