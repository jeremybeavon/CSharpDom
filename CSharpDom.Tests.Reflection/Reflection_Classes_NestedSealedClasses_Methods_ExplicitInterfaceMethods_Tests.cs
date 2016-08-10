using CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceMethodWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
