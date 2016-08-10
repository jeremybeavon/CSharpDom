using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithExplicitInterfaceMethodWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameterUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParametersUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithAttributesUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
