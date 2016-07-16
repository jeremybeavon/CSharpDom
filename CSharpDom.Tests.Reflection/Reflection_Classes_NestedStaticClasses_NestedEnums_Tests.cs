using CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_NestedEnums_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedEnumWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedEnumWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedEnumWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithProtectedNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithProtectedInternalNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedEnum));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicNestedEnumUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicNestedEnum));
        }
    }
}
