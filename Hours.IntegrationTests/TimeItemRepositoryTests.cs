using Hours.Core.Entities;
using Hours.Core.Repositories;
using NUnit.Framework;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hours.IntegrationTests
{
    [TestFixture]
    public class TimeItemRepositoryTests
    {
        HoursContext _context;
        Container _container;

        [SetUp]
        public void InitializeDependencies()
        {
            _context = new HoursContext();
            _container = new Container();

            _container.Configure(x =>
            {
                x.For<ITimeItemRepository>().Use<TimeItemRepository>()
                    .Ctor<HoursContext>("context")
                    .Is(_context);
            });

        }

        [Test]
        public void TimeItem_should_be_added()
        {
            // arrange
            var repo = _container.GetInstance<ITimeItemRepository>();

            // act
            var timeItem = new TimeItem() { Time = 1, Title = "Test" };
            repo.Add(timeItem);
            _context.SaveChanges();

            // assert
            var createdTimeItem = repo.GetById(timeItem.Id);

            Assert.IsNotNull(createdTimeItem);
            
        }

        [TearDown]
        public void Cleanup()
        {
            _context.TimeItems.RemoveRange(_context.TimeItems);
            _context.SaveChanges();
        }
        
    }
}
