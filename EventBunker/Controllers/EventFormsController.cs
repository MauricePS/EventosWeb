using EventBunker.Models;
using EventBunker.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventBunker.Controllers
{
    public class EventFormsController : Controller
    {
        private readonly EventFormService _eventFormService;

        public EventFormsController(EventFormService eventFormService)
        {
            _eventFormService = eventFormService;
        }

        public IActionResult Index()
        {
            var list = _eventFormService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create (EventForm eventForm)
        {
            _eventFormService.Insert(eventForm);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _eventFormService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _eventFormService.Remove(id);
            return RedirectToAction(nameof(Index));
        }      

    }
}
