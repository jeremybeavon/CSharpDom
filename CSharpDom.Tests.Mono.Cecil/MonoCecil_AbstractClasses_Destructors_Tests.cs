using CSharpDom.TestTarget.AbstractClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Destructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithDestructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithDestructor));
        }
    }
}
