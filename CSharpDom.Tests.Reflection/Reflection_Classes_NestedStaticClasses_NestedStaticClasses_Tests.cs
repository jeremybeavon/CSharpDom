using CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_NestedStaticClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedStaticClassWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedStaticClassWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedStaticClassWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalNestedStaticClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateNestedStaticClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedNestedStaticClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithProtectedInternalNestedStaticClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicNestedStaticClassUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicNestedStaticClass));
        }
    }
}
