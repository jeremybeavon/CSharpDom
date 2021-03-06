using CSharpDom.TestTarget.SealedClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Destructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithDestructorUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithDestructor));
        }
    }
}
