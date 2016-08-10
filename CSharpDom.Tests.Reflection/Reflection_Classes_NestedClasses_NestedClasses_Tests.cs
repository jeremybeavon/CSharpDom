using CSharpDom.TestTarget.Classes.NestedClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithBaseClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalNestedClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateNestedClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedNestedClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalNestedClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicNestedClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedClass));
        }
    }
}
