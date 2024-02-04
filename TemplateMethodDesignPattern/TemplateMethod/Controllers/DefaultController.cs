using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TemplateMethod.TemplatePattern;

namespace TemplateMethod.Controllers
{
    public class DefaultController:Controller
    {
        public IActionResult Index(){
            return View();
        }
        public IActionResult BasicPlanIndex(){
            NetflixPlans netflixPlans= new BasicPlan();
            ViewBag.planType=netflixPlans.PlanType("Basic Plan");
            ViewBag.countPerson=netflixPlans.CountPerson(1);
            ViewBag.price=netflixPlans.Price(64.99);
            ViewBag.content=netflixPlans.Content("Series");
            ViewBag.resolution=netflixPlans.Resolution("480px");
            return View();
        }
        public IActionResult StandartPlanIndex(){
            NetflixPlans netflixPlans= new StandartPlan();
            ViewBag.planType=netflixPlans.PlanType("Standart Plan");
            ViewBag.countPerson=netflixPlans.CountPerson(2);
            ViewBag.price=netflixPlans.Price(94.99);
            ViewBag.content=netflixPlans.Content("Series-Animation");
            ViewBag.resolution=netflixPlans.Resolution("720px");
            return View();
        }
        public IActionResult UltraPlanIndex(){
            NetflixPlans netflixPlans= new StandartPlan();
            ViewBag.planType=netflixPlans.PlanType("Ultra Plan");
            ViewBag.countPerson=netflixPlans.CountPerson(4);
            ViewBag.price=netflixPlans.Price(154.99);
            ViewBag.content=netflixPlans.Content("Series-Animation-Books");
            ViewBag.resolution=netflixPlans.Resolution("4K");
            return View();
        }
    }
}