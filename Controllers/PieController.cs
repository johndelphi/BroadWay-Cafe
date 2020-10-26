﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BroadWay_Cafe.Models;
using Microsoft.AspNetCore.Mvc;

namespace BroadWay_Cafe.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        public PieController(IPieRepository pieRepository,ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;

        }
        public ViewResult list()
        {
            return View(_pieRepository.Allpies);
        }
    }
}
