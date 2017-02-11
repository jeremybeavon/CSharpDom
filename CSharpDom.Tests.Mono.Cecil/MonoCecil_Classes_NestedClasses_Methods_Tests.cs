using CSharpDom.TestTarget.Classes.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualMethodUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithVirtualMethod));
        }
    }
}
