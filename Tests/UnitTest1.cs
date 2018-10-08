using ApartmentApp.Domain;
using ApartmentApp.Domain.Interfaces;
using ApartmentApp.Domain.SimpleRepo;
using ApartmentApp.WebMvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ApartmentApp.WebMvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace Tests
{
    public class ApartmentsControllerTests
    {
        [Fact]
        public async Task IndexTest1()
        {

            var builder = new WebHostBuilder()
                .UseContentRoot(Environment.GetEnvironmentVariable("ApartmentsAppSrc"))
                .UseEnvironment("Development")
                .UseStartup<Startup>();
            TestServer server = new TestServer(builder);
            var client = server.CreateClient();
            HttpResponseMessage resp = await client.GetAsync("/Apartments/Index");
            // Fail the test if non-success result
            resp.EnsureSuccessStatusCode();

            // Get the response as a string
            string responseHtml = await resp.Content.ReadAsStringAsync();

            // Assert on correct content
            Assert.Contains(" вартиры", responseHtml);
        }

     
    }
}
