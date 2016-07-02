using CSharpDom.TestTarget.Classes.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivatePropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticProperty));
        }
    }
}
