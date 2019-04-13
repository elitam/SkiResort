using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using SkiResort.Business;
using SkiResort.Data;
using SkiResort.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiResort.Tests
{
    public class TrailControllerTest
    {
        [TestCase]
        public void AddTrailToDatabase()
        {
            var data = new List<Trail>()
            {
                new Trail("a","Beginner", "Green"),
                new Trail("b","Beginner", "Green")
            }.AsQueryable();


            var mockSet = new Mock<DbSet<Trail>>();
            mockSet.As<IQueryable<Trail>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Trail>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Trail>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Trail>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<SkiResortContext>();
            mockContext.Setup(c => c.Trails).Returns(mockSet.Object);

            var service = new TrailController(mockContext.Object);
            data.ToList().ForEach(t => service.Add(t));
        }

        [TestCase]
        public void GetAllTrailsFromDatabase()
        {
            var data = new List<Trail>
            {
                new Trail { Name="First" },
                new Trail { Name="Second" },
                new Trail { Name="Third" },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Trail>>();
            mockSet.As<IQueryable<Trail>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Trail>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Trail>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Trail>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<SkiResortContext>();
            mockContext.Setup(c => c.Trails).Returns(mockSet.Object);

            var controller = new TrailController(mockContext.Object);
            var trails = controller.GetAll();

            Assert.AreEqual(3, trails.Count);
            Assert.AreEqual("First", trails[0].Name);
            Assert.AreEqual("Second", trails[1].Name);
            Assert.AreEqual("Third", trails[2].Name);
        }

        //[TestCase]
        //public void GetTrail()
        //{
        //    var data = new List<Trail>
        //    {
        //        new Hike { Id=1,StartPoint="First" },
        //        new Hike { Id=2,StartPoint="Second" },
        //        new Hike { Id=3,StartPoint="Third" },
        //    }.AsQueryable();

        //    var mockSet = new Mock<DbSet<Hike>>();
        //    mockSet.As<IQueryable<Hike>>().Setup(m => m.Provider).Returns(data.Provider);
        //    mockSet.As<IQueryable<Hike>>().Setup(m => m.Expression).Returns(data.Expression);
        //    mockSet.As<IQueryable<Hike>>().Setup(m => m.ElementType).Returns(data.ElementType);
        //    mockSet.As<IQueryable<Hike>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

        //    var mockContext = new Mock<SkiResortContext>();
        //    mockContext.Setup(c => c.Hikes).Returns(mockSet.Object);

        //    var controller = new HikeController(mockContext.Object);
        //    var hike = controller.Get(1);

        //    Assert.AreEqual("First", hike.StartPoint);


        //}
    }
}