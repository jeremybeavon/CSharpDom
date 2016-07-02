using CSharpDom.TestTarget.AbstractClasses.Destructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Destructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithDestructorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithDestructor));
        }
    }
}
