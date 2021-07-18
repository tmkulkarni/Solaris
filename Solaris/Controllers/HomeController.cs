﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Solaris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Solaris.Controllers
{
    public class HomeController : Controller
    {
        HttpClient httpClient;

        static string BASE_URL = "https://data.ny.gov/resource/";
        static string API_KEY = "39zypx1hn3e0qesz7caa8maz3i0ffm82323wac1ou2fejrlbui";
        //static string API_KEY = "xkM5aWJ0tOyJt55T5QiPmgRv7nQDJaMPaMDPf98C";
        public IActionResult Index()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string SOLARIS_API_PATH = BASE_URL + "3x8r-34rs.json";
            string solarisData = "";

            RootSolaris rootSolaris = new RootSolaris();


            httpClient.BaseAddress = new Uri(SOLARIS_API_PATH);

           

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(SOLARIS_API_PATH)
                                                        .GetAwaiter().GetResult();
                //HttpResponseMessage response = httpClient.GetAsync(BASE_URL)
                //                                        .GetAwaiter().GetResult();



                if (response.IsSuccessStatusCode)
                {
                    solarisData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!solarisData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                      rootSolaris.Data = JsonConvert.DeserializeObject<List<Solaris.Models.Solaris>>(solarisData);
                }

                
                //dbContext.Parks.Add(parks);
                //await dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return View(rootSolaris);

        }

        public IActionResult master()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string SOLARIS_API_PATH = BASE_URL + "3x8r-34rs.json";
            string solarisData = "";

            RootSolaris rootSolaris = new RootSolaris();


            httpClient.BaseAddress = new Uri(SOLARIS_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(SOLARIS_API_PATH)
                                                        .GetAwaiter().GetResult();
                //HttpResponseMessage response = httpClient.GetAsync(BASE_URL)
                //                                        .GetAwaiter().GetResult();



                if (response.IsSuccessStatusCode)
                {
                    solarisData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!solarisData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                       rootSolaris.Data = JsonConvert.DeserializeObject<List<Solaris.Models.Solaris>>(solarisData);
                }

            }

            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return View(rootSolaris);
        }

        public IActionResult detail()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string SOLARIS_API_PATH = BASE_URL + "3x8r-34rs.json";
            string solarisData = "";

            RootSolaris rootSolaris = new RootSolaris();


            httpClient.BaseAddress = new Uri(SOLARIS_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(SOLARIS_API_PATH)
                                                        .GetAwaiter().GetResult();
                //HttpResponseMessage response = httpClient.GetAsync(BASE_URL)
                //                                        .GetAwaiter().GetResult();



                if (response.IsSuccessStatusCode)
                {
                    solarisData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!solarisData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                       rootSolaris.Data = JsonConvert.DeserializeObject<List<Solaris.Models.Solaris>>(solarisData);
                }

            }

            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }
            return View(rootSolaris);
        }

        public IActionResult aboutus()
        {
            return View();
        }
    }
}







