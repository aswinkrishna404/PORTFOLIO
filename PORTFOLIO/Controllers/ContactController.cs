﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PORTFOLIO.Data;
using PORTFOLIO.Models;

namespace PORTFOLIO.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public ContactController(ApplicationDbContext applicationDbContext)
        {

            _dbContext = applicationDbContext;

        }
   

        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _dbContext.ContactForm.Add(contact);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(contact));
            }
            return View(contact);
        }
    }
}
