using CSharpDom.TestTarget.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWith1GenericParameterUsingReflection()
        {
            TestClass(typeof(ClassWith1GenericParameter<>));
        }

        [TestMethod]
        public void TestClassWith1ImplementedInterfaceUsingReflection()
        {
            TestClass(typeof(ClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWith2GenericParametersUsingReflection()
        {
            TestClass(typeof(ClassWith2GenericParameters<,>));
        }

        [TestMethod]
        public void TestClassWith2ImplementedInterfacesUsingReflection()
        {
            TestClass(typeof(ClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithBaseClassUsingReflection()
        {
            TestClass(typeof(ClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithGenericParameterClassAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithGenericParameterBaseClassConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithGenericParameterClassConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithGenericParameterEmptyConstructorConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithGenericParameterGenericParameterConstraint<,>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithGenericParameterInterfaceConstraint<>));
        }

        [TestMethod]
        public void TestClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithGenericParameterStructConstraint<>));
        }

        [TestMethod]
        public void TestInternalClassUsingReflection()
        {
            TestClass(typeof(InternalClass));
        }

        [TestMethod]
        public void TestPublicClassUsingReflection()
        {
            TestClass(typeof(PublicClass));
        }
    }
}
