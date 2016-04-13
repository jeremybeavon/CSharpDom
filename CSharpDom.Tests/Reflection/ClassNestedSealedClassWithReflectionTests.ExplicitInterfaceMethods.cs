using CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedSealedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExplicitInterfaceWithMethodWithParametersWithAttributes()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}