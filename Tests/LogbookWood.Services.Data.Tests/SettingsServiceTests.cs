﻿namespace LogbookWood.Services.Data.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using LogbookWood.Data;
    using LogbookWood.Data.Common.Repositories;
    using LogbookWood.Data.Repositories;
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using Xunit;

    public class SettingsServiceTests
    {
        ////[Fact]
        ////public void GetCountShouldReturnCorrectNumber()
        ////{
        ////    Mock<IDeletableEntityRepository<Setting>> repository = new Mock<IDeletableEntityRepository<Setting>>();
        ////    repository.Setup(r => r.All()).Returns(new List<Setting>
        ////                                                {
        ////                                                    new Setting(),
        ////                                                    new Setting(),
        ////                                                    new Setting(),
        ////                                                }.AsQueryable());
        ////    var service = new SettingsService(repository.Object);
        ////    Assert.Equal(3, service.GetCount());
        ////    repository.Verify(x => x.All(), Times.Once);
        ////}

        ////[Fact]
        ////public async Task GetCountShouldReturnCorrectNumberUsingDbContext()
        ////{
        ////    DbContextOptions<ApplicationDbContext> options = new DbContextOptionsBuilder<ApplicationDbContext>()
        ////        .UseInMemoryDatabase(databaseName: "SettingsTestDb").Options;
        ////    using ApplicationDbContext dbContext = new ApplicationDbContext(options);
        ////    dbContext.Settings.Add(new Setting());
        ////    dbContext.Settings.Add(new Setting());
        ////    dbContext.Settings.Add(new Setting());
        ////    await dbContext.SaveChangesAsync();

        ////    using EfDeletableEntityRepository<Setting> repository = new EfDeletableEntityRepository<Setting>(dbContext);
        ////    var service = new SettingsService(repository);
        ////    Assert.Equal(3, service.GetCount());
        ////}
    }
}
