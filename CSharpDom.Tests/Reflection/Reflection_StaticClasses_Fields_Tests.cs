using CSharpDom.TestTarget.StaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithConstrFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithConstrField));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithReadOnlyFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithVolatileField));
        }
    }
}
