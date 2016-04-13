using CSharpDom.TestTarget.Classes.NestedClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceMethodWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceMethodWith1GenericParameter()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceMethodWith2GenericParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceWithMethodWithParametersWithAttributes()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceMethodWithParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}