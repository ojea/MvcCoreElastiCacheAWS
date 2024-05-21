﻿using Microsoft.AspNetCore.Mvc;
using MvcCoreElastiCacheAWS.Models;
using MvcCoreElastiCacheAWS.Repositories;

namespace MvcCoreElastiCacheAWS.Controllers
{
    public class CocheController: Controller
    {
        private RepositoryCoches repo;

        public CocheController(RepositoryCoches repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()

        {
            List<Coche> coches = this.repo.GetCoches();
            return View(coches);
        }

        public IActionResult Details(int id)
        {
            Coche coche = this.repo.FindCoche(id);
            return View(coche);
        }
    }
}
