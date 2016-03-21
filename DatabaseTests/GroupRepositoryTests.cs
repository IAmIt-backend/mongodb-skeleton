using System;
using DatabaseAbstractions.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseTests
{
    [TestClass]
    public class GroupRepositoryTests
    {
        private IGroupRepository _repository;
        
        [TestInitialize]
        public void Initialize()
        {
            _repository = null;
        }

        [TestMethod]
        public void AddingExistingMemberTest()
        {
            // arrange
            

            // act


            // assert
        }
    }
}
