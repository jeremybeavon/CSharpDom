using CSharpDom.TestTarget.Classes.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivatePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicProperty));
        }
    }
}
