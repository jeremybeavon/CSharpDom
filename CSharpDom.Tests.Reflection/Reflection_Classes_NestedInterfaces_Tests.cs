using CSharpDom.TestTarget.Classes.NestedInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedInterfaces_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedInterfaceWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith1GenericParameterUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith1ImplementedInterfaceUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith2GenericParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWith2ImplementedInterfacesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedInterfaceWithGenericParameterStructConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedInterfaceWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithProtectedNestedInterfaceUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedNestedInterface));
        }

        [TestMethod]
        public void TestClassWithPrivateNestedInterfaceUsingReflection()
        {
            TestClass(typeof(ClassWithPrivateNestedInterface));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalNestedInterfaceUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedInternalNestedInterface));
        }

        [TestMethod]
        public void TestClassWithInternalNestedInterfaceUsingReflection()
        {
            TestClass(typeof(ClassWithInternalNestedInterface));
        }

        [TestMethod]
        public void TestClassWithPublicNestedInterfaceUsingReflection()
        {
            TestClass(typeof(ClassWithPublicNestedInterface));
        }
    }
}
